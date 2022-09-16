using Microsoft.AspNetCore.Mvc;
using DitsPortal_Service.IService;
using DitsPortal.Common.Requests;
using DitsPortal.Common.Responses;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using DitsPortal.Common.StaticResource;
using System.Text;


using AutoMapper;

namespace assignment.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
  
    public class UserRegisterController : ControllerBase
    {
        private readonly IUserService _IUserService;
        private readonly IMapper mapper;
        private IConfiguration _config;
        
        //private UserResponse _response;
        public UserRegisterController(IUserService IUserService, IMapper _mapper, IConfiguration config)
        {
            _IUserService = IUserService;
            mapper = _mapper;
            _config = config;
              //_response = response;
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterRequest register)
        {
            UserResponse response = new UserResponse();
            var res = await _IUserService.AddUser(register);
            
             if (res != null)
            {
                response.Message = Constants.USER_REGISTERED;
            }
            else
            {
                response.Message = Constants.USER_WAIT_APPROVAL;

            }
            var datas = mapper.Map<UserResponse>(res);
            return new OkObjectResult(datas);
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            try
            {
               
                var res = _IUserService.Login(email, password);
                var token=GenerateToken(res.UserId, res.Email);
                // var mappers = mapper.Map<UserResponse>(res);
                return new OkObjectResult(token);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        [HttpPost]
        public IActionResult VerifyCode(int userId, int code){
            var res=_IUserService.CodeVerification(userId, code);
            //  var mappers = mapper.Map<UserResponse>(res);
            return new OkObjectResult(res);
            
        }
        #region JWT Functions
        private string GenerateToken(int id, string email)
        {
    
            var claims = new[] {
                        new Claim(JwtRegisteredClaimNames.Sub, _config["Jwt:Subject"]),
                       // This represents a unique identifier for the token.
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                        // This represents the time when the token was issued.
                        new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                        new Claim("SignupId",  id.ToString()),
                        new Claim("Email", email),

                    };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                _config["Jwt:Issuer"],
                _config["Jwt:Audience"],
                claims,
                expires: DateTime.UtcNow.AddMinutes(120),
                signingCredentials: signIn);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        #endregion
        [HttpPost]
        public async Task<IActionResult>Forgetpassword(ForgotPasswordRequest fgtpass){
            var data=await _IUserService.forgetPassword(fgtpass);
             var mappers = mapper.Map<UserResponse>(data);
            return new OkObjectResult(mappers);
        }
    }
}