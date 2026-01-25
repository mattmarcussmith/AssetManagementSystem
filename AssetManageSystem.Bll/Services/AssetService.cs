using InternalAssetManage.Dal.ApplicationDbContext;
using InternalAssetManage.Dal.Entities;
using InternalAssetManage.Shared.Dto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalAssetManage.Bll.Services
{
    public interface IAssetService
    {
        Task<AssetDetailsDto> CreateAssetAsync(CreateAssetDto createAssetDto);
        Task RetireAssetAsync(RetireAssetDto retireAssetDto);
        Task<AssetDetailsDto> GetAssetDetailsAsync(int Id);
        Task<List<AssetDetailsDto>> GetAllAssetsAsync();
    }

    public class AssetService : IAssetService
    {
        private readonly AppDbContext _dbContext;
        public AssetService(AppDbContext dbContext) => _dbContext = dbContext;

        public async Task<List<AssetDetailsDto>> GetAllAssetsAsync()
        {
            return await _dbContext.Assets
                .Where(x => !x.IsRetired)
                .Select(x => new AssetDetailsDto
                {
                    Id = x.Id,
                    AssetTag = x.AssetTag,
                    Name = x.Name,
                    Category = x.Category,
                    Location = x.Location,
                    IsRetired = x.IsRetired
                })
                .ToListAsync();
        }

        public async Task<AssetDetailsDto> GetAssetDetailsAsync(int Id)
        {
            var asset = _dbContext.Assets.FirstOrDefault(x => x.Id == Id) 
                ?? throw new Exception("Asset not found");

            return new AssetDetailsDto
            {
                Id = asset.Id,
                AssetTag = asset.AssetTag,
                Name = asset.Name,
                Category = asset.Category,
                Location = asset.Location,
                IsRetired = asset.IsRetired,
            };
        }

        public async Task<AssetDetailsDto> CreateAssetAsync(CreateAssetDto createAssetDto)
        {
            var asset = new Asset
            {
                AssetTag = createAssetDto.AssetTag,
                Name = createAssetDto.Name,
                Category = createAssetDto.Category,
                Location = createAssetDto.Location,
                IsRetired = false,
            };

            _dbContext.Assets.Add(asset);
            await _dbContext.SaveChangesAsync();

            return new AssetDetailsDto
            {
                Id = asset.Id,
                AssetTag = asset.AssetTag,
                Name = asset.Name,
                Category = asset.Category,
                Location = asset.Location,
                IsRetired = asset.IsRetired,
            };
        }

        public Task RetireAssetAsync(RetireAssetDto retireAssetDto)
        {
            var asset = _dbContext.Assets.FirstOrDefault(x => x.Id == retireAssetDto.Id)
                ?? throw new Exception("Asset not found");

            asset.IsRetired = true;

            _dbContext.Assets.Update(asset);
            return _dbContext.SaveChangesAsync();
        }
    }
}
