namespace AssetManage.Shared.Dto;

public class SearchAssetDto
{
    public string? AssetTag { get; set; } 
    public string? Name { get; set; } 
    public string? Category { get; set; } 
    public string? Location { get; set; }
    public bool? IsRetired { get; set; }
}