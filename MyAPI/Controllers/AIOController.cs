using Microsoft.AspNetCore.Mvc;
using MyAPI.Helpers;
using MyAPI.Interfaces;
using System.Threading.Tasks;

namespace MyAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AIOController : ControllerBase
    {
        private IAIOService aioService;

        public AIOController(IAIOService aioService)
        {
            this.aioService = aioService;
        }

        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get()
        {
            var aio = await aioService.GetAIO();

            var aioModel = AIOHelper.ConvertAIO(aio);
            aioModel.setDict();

            return Ok(aioModel.Dict);
        }
    }
}
