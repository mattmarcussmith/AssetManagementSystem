using AssetManage.Bll.Services;
using AssetManage.Shared.Dto;

using Microsoft.AspNetCore.Mvc;

namespace AssetManage.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetController(IAssetService assetService) : ControllerBase
    {

        [HttpGet("get-asset-details")]
        public async Task<ActionResult<AssetDetailsDto>> GetAssetDetailsAsync([FromQuery] int id)
        {
            try
            {
                return await assetService.GetAssetDetailsAsync(id);
            }
            catch (InvalidOperationException ex)
            {
                return NotFound();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        [HttpGet("get-all-assets")]
        public async Task<ActionResult<List<AssetDetailsDto>>> GetAllAssetsAsync()
        {
            try
            {
                var assets = await assetService.GetAllAssetsAsync();
                return Ok(assets);
            }
            catch 
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }

        [HttpPost("create-asset")]
        public async Task<ActionResult<AssetDetailsDto>> CreateAssetAsync([FromBody] CreateAssetDto dto)
        {
            try
            {
                var create = await assetService.CreateAssetAsync(dto);
                return Ok(create);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);

            }

        }

        [HttpPost("retire-asset")]
        public async Task<ActionResult> RetireAssetAsync([FromBody] RetireAssetDto dto)
        {
            try
            {
                await assetService.RetireAssetAsync(dto);
                return Ok();
            }
            catch (InvalidOperationException)
            {
                return NotFound();
            }
            catch 
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
