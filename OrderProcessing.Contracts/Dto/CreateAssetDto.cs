namespace InternalAssetManage.Shared.Dto
{
    public class CreateAssetDto
    {
        public string AssetTag { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
    }
}
