using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Domain.Models;
using DitsPortal.Common.Requests;
using DitsPortal_Service.IService;
namespace assignment.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class GlobalCodeController : ControllerBase
    {



        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IGlobalCodesService _IGlobalCodesService;

        private readonly IMapper mapper;
        public GlobalCodeController(IMapper _mapper, IGlobalCodesService IGlobalCodesService)
        {

            _IGlobalCodesService = IGlobalCodesService;
            mapper = _mapper;

        }
        [HttpPost]
        public async Task<IActionResult> GlobalCode(GlobalCodeRequest gcReq)
        {
            var res = await _IGlobalCodesService.create_GlobalCode(gcReq);  
             var datas=mapper.Map<GlobalCodes>(res); 
             return new OkObjectResult(datas);
            
        }
    }
}