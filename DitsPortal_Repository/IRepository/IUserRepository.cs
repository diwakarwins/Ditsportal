using Domain.Models;
using DitsPortal.Common.Requests;
using DitsPortal.Common.Responses;
using SendGrid;

namespace DitsPortal_Repository.IRepository
{
    public interface IUserRepository
    {
        Task<User> RegisterUser(UserRegisterRequest register);
        User Login(string email, string password);
        Task<User> Changepaswword(ChangePasswordRequest chngpass);
        Task<User>Forgetpassword(ForgotPasswordRequest fgtpass);
        ResponseDTO CodeVerify(int userId, int code);
      
}
}