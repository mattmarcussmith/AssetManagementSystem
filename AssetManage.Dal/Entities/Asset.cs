namespace AssetManage.Dal.Entities
{
    public class Asset
    {
        public int Id { get; set; }
        public string AssetTag { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public bool IsRetired { get; set; }
    }
}
