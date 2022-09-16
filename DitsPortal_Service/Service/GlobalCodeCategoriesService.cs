using DitsPortal_Service.IService;
using DitsPortal_Repository.IRepository;
using DitsPortal.Common.Responses;
using DitsPortal.Common.Requests;
using DitsPortal.Common;
using Domain.Models;
using AutoMapper;

namespace DitsPortal_Service.Service
{
    public class GlobalCodeCategoriesService : IGlobalCodeCategoriesService
    {


        private readonly IGlobalCodeCategoriesRepository _gcCategoriesIRepository;




        public GlobalCodeCategoriesService(IGlobalCodeCategoriesRepository gcCategoriesIRepository)
        {
            _gcCategoriesIRepository = gcCategoriesIRepository;

        }

        public async Task<GlobalCodeCategories> CreateGlobalCategory(GCCategoryRequest gcCategoryRequest)
        {

            var test = await _gcCategoriesIRepository.CreateCategory(gcCategoryRequest);
            return test;

        }
        public async Task<List<GlobalCodeCategories>>GetallCategorydata()
        {
            var result = await _gcCategoriesIRepository.GetCategorydata();
            return result;
        }
        public async Task<GlobalCodeCategories>GetallcategorydataById(int id){
            var result= await _gcCategoriesIRepository.GetcategorydataById(id);
            return result;
        }

    }

}

