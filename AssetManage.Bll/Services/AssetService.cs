using AssetManage.Dal.ApplicationDbContext;
using AssetManage.Dal.Entities;
using AssetManage.Shared.Dto;
using Microsoft.EntityFrameworkCore;

namespace AssetManage.Bll.Services
{
    public interface IAssetService
    {
        Task<AssetDetailsDto> CreateAssetAsync(CreateAssetDto createAssetDto);
        Task RetireAssetAsync(RetireAssetDto retireAssetDto);
        Task<AssetDetailsDto> GetAssetDetailsAsync(int id);
        Task<List<AssetDetailsDto>> GetAllAssetsAsync();
    }

    public class AssetService(AppDbContext dbContext) : IAssetService
    {
        public async Task<List<AssetDetailsDto>> GetAllAssetsAsync()
        {
            return await dbContext.Assets
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

        public async Task<AssetDetailsDto> GetAssetDetailsAsync(int id)
        {
            var asset = await dbContext.Assets.FirstOrDefaultAsync(x => x.Id == id)
                        ?? throw new InvalidOperationException("Asset not found");

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

            dbContext.Assets.Add(asset);
            await dbContext.SaveChangesAsync();

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
            var asset = dbContext.Assets.FirstOrDefault(x => x.Id == retireAssetDto.Id)
                ?? throw new InvalidOperationException("Asset not found");

            asset.IsRetired = true;

            dbContext.Assets.Update(asset);
            return dbContext.SaveChangesAsync();
        }
    }
}
