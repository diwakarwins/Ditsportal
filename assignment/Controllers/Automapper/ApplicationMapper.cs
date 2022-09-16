using AutoMapper;
using DitsPortal.Common.Requests;
using DitsPortal.Common.Responses;
using Domain.Models;
namespace assignment.Controllers.AutoMapper
{
    public class ApplicationMapper : Profile
    {
        public ApplicationMapper()
        {       //Request mapping
            CreateMap<GlobalCodeCategories, GCCategoryRequest>();

            CreateMap<GlobalCodeCategories, GlobalCodeCategoriesResponse>();
            CreateMap<User, UserRegisterRequest>();
            // CreateMap<GlobalCodes, GlobalCodeRequest>();
            CreateMap<UserResponse, User>().ReverseMap();

            //Response Mapping
            CreateMap<GlobalCodeCategoriesResponse, GlobalCodeCategories>();




        }
    }
}
