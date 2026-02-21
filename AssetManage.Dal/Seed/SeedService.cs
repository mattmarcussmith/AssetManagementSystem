using AssetManage.Dal.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;

namespace AssetManage.Dal.Seed
{
    public static class SeedService
    {
        public static async Task SeedDataAsync(AppDbContext dbAppContext)
        {
            if (await dbAppContext.Assets.AnyAsync())
            {
                return;
            }

            var assets = SeedData.GetAssets();
            await dbAppContext.Assets.AddRangeAsync(assets);

            await dbAppContext.SaveChangesAsync();
        }
    }
}
