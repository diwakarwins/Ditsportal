using Microsoft.AspNetCore.Mvc;
using DitsPortal_Service.IService;
using Domain.Models;
using DitsPortal.Common.Responses;
using AutoMapper;
using DitsPortal.Common.Requests;
using Microsoft.AspNetCore.Authorization;

namespace assignment.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    [Authorize]
    public class GlobalCodeCategoriess : ControllerBase
    {
        private IGlobalCodeCategoriesService _IGlobalCodeCategoriesService;
        private readonly IMapper mapper;
        public GlobalCodeCategoriess(IGlobalCodeCategoriesService IGlobalCodeCategoriesService, IMapper _mapper)
        {
            _IGlobalCodeCategoriesService = IGlobalCodeCategoriesService;
            mapper = _mapper;

        }

        [HttpPost]
        public async Task<IActionResult> createGlobalCategory(GCCategoryRequest req)
        {
            var res = await _IGlobalCodeCategoriesService.CreateGlobalCategory(req);
            var datas = mapper.Map<GlobalCodeCategories>(res);
            return new OkObjectResult(datas);
        }
        [HttpGet]
        public async Task<IActionResult> GetGlobalCategories()
        {
            try
            {
                var res = await _IGlobalCodeCategoriesService.GetallCategorydata();

                var datas = mapper.Map<List<GlobalCodeResponse>>(res);
                return new OkObjectResult(datas);
            }
            catch (Exception e)
            {

                throw;
            }
        }
        [HttpGet]
        public async Task<IActionResult> getGlobalId(int id)
        {
            var res = await _IGlobalCodeCategoriesService.GetallcategorydataById(id);
            var datas = mapper.Map<GlobalCodeResponse>(res);
            return new OkObjectResult(datas);

        }

    }
}