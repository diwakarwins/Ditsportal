using Domain.Models;
using DitsPortal.Common.Requests;
using DitsPortal_Service.IService;
using DitsPortal_Repository.IRepository;
using DitsPortal.Common.Responses;
using DitsPortal.Common.StaticResource;
using AutoMapper;
namespace DitsPortal_Service.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _IUserRepository;
        private readonly IMapper mapper;
        public UserService(IUserRepository IUserRepository, IMapper _mapper)
        {
            _IUserRepository = IUserRepository;
            mapper = _mapper;
          
        }

        public async Task<User> AddUser(UserRegisterRequest register)
        {
            var data = await _IUserRepository.RegisterUser(register);
            // var datas = mapper.Map<User>(data);
           
            return data;

        }
        public User Login(string email, string password)
        {

            var data = _IUserRepository.Login(email, password);
            return data;
        }
        public ResponseDTO CodeVerification(int userId, int code){
            var data=_IUserRepository.CodeVerify(userId,code);
            return data;
        }


        public async Task<User> changePassword(ChangePasswordRequest chngpass)
        {
            var data = await _IUserRepository.Changepaswword(chngpass);
            return data;

        }
        public async Task<User> forgetPassword(ForgotPasswordRequest fgtpass)
        {
            var data = await _IUserRepository.Forgetpassword(fgtpass);
            return data;
        }
    }
}