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
        Task<List<AssetDetailsDto>> SearchAssetsAsync(SearchAssetDto searchAssetDto);
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

        public async Task<List<AssetDetailsDto>> SearchAssetsAsync(SearchAssetDto searchAssetDto)
        {
            IQueryable<Asset> searchDatabase = dbContext.Assets;

            if (!string.IsNullOrWhiteSpace(searchAssetDto.Name))
            {
                var name = searchAssetDto.Name.Trim();
                searchDatabase =  searchDatabase.Where(x => x.Name.Contains(name));
            }

            if (!string.IsNullOrWhiteSpace(searchAssetDto.Category))
            {
                var category = searchAssetDto.Category.Trim();
                searchDatabase = searchDatabase.Where(x => x.Category.Contains(category));
            }

            if (!string.IsNullOrWhiteSpace(searchAssetDto.Location))
            {
                var location = searchAssetDto.Location.Trim();
                searchDatabase = searchDatabase.Where(x => x.Location.Contains(location));
            }

            
            if (searchAssetDto.IsRetired.HasValue)
            {
                var isRetired = searchAssetDto.IsRetired;
                searchDatabase = searchDatabase.Where(x => x.IsRetired == isRetired);
            }

            var assetList = await searchDatabase
                .Select(x => new AssetDetailsDto()
                {
                    Id = x.Id,
                    AssetTag = x.AssetTag,
                    Name = x.Name,
                    Category = x.Category,
                    Location = x.Location,
                    IsRetired = x.IsRetired
                })
                .ToListAsync();

            return assetList;
        }
    }
}
