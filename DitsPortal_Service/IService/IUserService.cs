using Domain.Models;
using DitsPortal.Common.Requests;
using DitsPortal.Common.Responses;
namespace DitsPortal_Service.IService
{
    public interface IUserService
    {
        Task<User> AddUser(UserRegisterRequest register);
        public User Login(string email, string password);
        Task<User> changePassword(ChangePasswordRequest chngpass);
        Task<User> forgetPassword(ForgotPasswordRequest fgtpass);
        ResponseDTO CodeVerification(int userId, int code);

    }
}