using Domain.Data;
using Domain.Models;
using DitsPortal.Common.Requests;
using DitsPortal_Repository.IRepository;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Options;
using DitsPortal.Common;



using System.Text;
using DitsPortal.Common.StaticResource;
using DitsPortal.Common.Responses;

namespace DitsPortal_Repository.Repository
{
    public class UserRepository : IUserRepository
    {
        private IConfiguration _config;

        // private readonly Random _random;
        // private readonly ISendGridClient _sendGridClient;
        // private readonly EmailOptions emailOptions;
        private readonly IOptions<AppSettings> _settings;


        ApplicationDBContext ObjectContext;
        public UserRepository(ApplicationDBContext context, IConfiguration config, IOptions<AppSettings> settings)
        {
            ObjectContext = context;

            _config = config;
            // _random = random;

            // _sendGridClient = sendGridClient;
            // emailOptions = _emailOptions;
            // this.emailOptions = emailOptions.Value;
            _settings = settings;



        }
        // user reister---------------------------
        public async Task<User> RegisterUser(UserRegisterRequest register)
        {
            User user = new User();
            try
            {
                var encodePassword = DitsPortal.Common.EncodeComparePassword.CreateMD5(register.Password);
                user.UserName = register.UserName;
                user.FirstName = register.FirstName;
                user.LastName = register.LastName;
                user.Gender = register.Gender;
                user.DateOfBirth = register.DateOfBirth;
                user.Designation = register.Designation;
                user.Phone = register.Phone;
                user.AlternateNumber = register.AlternateNumber;
                user.Email = register.Email;
                user.Password = encodePassword;
                user.Skype = register.Skype;
                user.OfficialEmail = register.OfficialEmail;
                user.PAN = register.PAN;
                user.BloodGroup = register.BloodGroup;
                user.DateOfJoining = register.DateOfjoining;
                user.DateOfLeaving = register.DateOfLeaving;
                user.CreatedBy = register.ActionBy;
                user.CreatedOn = DateTime.Now;
                user.IsApproved = register.IsApproved;

                await ObjectContext.Users.AddAsync(user);
                await ObjectContext.SaveChangesAsync();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);

            }
            return user;


        }


        // user login---------------------------------
        public User Login(string email, string password)
        {
            // User obj = new User();
            Random _random = new Random();
            DateTime currentTime = DateTime.Now;

            var encodePassword = DitsPortal.Common.EncodeComparePassword.CreateMD5(password);
            int otp = _random.Next(000000, 999999);
            
            var user = ObjectContext.Users.FirstOrDefault(x => x.Email == email && x.Password == encodePassword);
            string link = "http://127.0.0.1:5500/ForgotPassword.html";
            // obj = (from T1 in ObjectContext.Users
            //        where T1.Email == email && T1.Password == encodePassword && T1.IsActive == true
            //        select new User
            //        {
            //    Email = T1.Email;
            //    UserName = T1.UserName,
            //    UserId = T1.UserId,
            //    FirstName = T1.FirstName,
            //    LastName = T1.LastName
            //    }).FirstOrDefault();
            var sendGridClient = new SendGridClient(_settings.Value.ApiKey);
            var sendGridMessage = new SendGridMessage();
            sendGridMessage.SetFrom(_settings.Value.Email, _settings.Value.Name);
            sendGridMessage.AddTo(user.Email);
            sendGridMessage.SetTemplateId(_settings.Value.TemplateId);
            sendGridMessage.SetTemplateData(new
            {
                Link = otp + "?UserId=" + user.UserId + "?link" + link
            });
            var response = sendGridClient.SendEmailAsync(sendGridMessage);
            user.Code = otp;
            user.CodeExpired = currentTime.AddMinutes(30);
            ObjectContext.SaveChangesAsync();
            return user;


        }

        public ResponseDTO CodeVerify(int userId, int code)
        {
            ResponseDTO model = new ResponseDTO();
            var user = ObjectContext.Users.Where(x => x.UserId == userId && x.Code == code).FirstOrDefault();

            if (user!=null)
            {
                if (DateTime.Now <= user.CodeExpired)
                    {
                        model.keyId = user.UserId;
                        model.RespnseCode = 200;
                        model.ResponseMessage = "Login successfull";
                    }
                else
                    {
                        model.keyId = user.UserId;
                        model.RespnseCode = 500;
                        model.ResponseMessage = "Your OTP time expired! please try again.";
                    }
            }
            else
                {
                    model.keyId = 0;
                    model.RespnseCode = 200;
                    model.ResponseMessage = "  User not found";
                }
            return model;

        }

        //user change password------------------------------------

        public async Task<User> Changepaswword(ChangePasswordRequest chngpass)
        {
            // User obj=new User();
            var user = ObjectContext.Users.Where(x => x.Email == chngpass.Email && x.IsActive == true).FirstOrDefault();
            try
            {
                if (user != null)
                {
                    var encodePassword = DitsPortal.Common.EncodeComparePassword.CreateMD5(chngpass.NewPassword);
                    user.Password = encodePassword;
                    user.ModifiedBy = chngpass.UserName;
                    user.ModifiedOn = DateTime.Now;
                    await ObjectContext.SaveChangesAsync();
                }
                return user;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

        }


        private string GenerateJSONWebToken(int userId, string email)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.UniqueName, email),
                new Claim(JwtRegisteredClaimNames.NameId, Convert.ToString(userId)),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
             };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                                            _config["Jwt:Audience"],
                                            claims,
                                            expires: DateTime.Now.AddMinutes(120),
                                            signingCredentials: credentials
                                            );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        // user forget password------------------------------
        public async Task<User> Forgetpassword(ForgotPasswordRequest fgtpass)
        {

            ///---------Using Send Grid sending email------------------------------

            var url = "http://127.0.0.1:5500/ForgotPassword.html";
            var user = ObjectContext.Users.Where(x => x.Email == fgtpass.Email && x.IsActive == true).FirstOrDefault();
            var token = GenerateJSONWebToken(user.UserId, user.Email);
            try
            {
                if (user != null)
                {
                    // var apiKey = "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";
                    // var client = new SendGridClient(_settings.Value.ApiKey);
                    // var from = new EmailAddress(_settings.Value.Email);
                    // var subject = _settings.Value.Subject;
                    // var to = new EmailAddress(user.Email);
                    // var plainTextContent = _settings.Value.Body + "?_link=" + token;
                    //  var template = _settings.Value.TemplateId+plainTextContent;
                    // var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent,template);
                    // var response = client.SendEmailAsync(msg);

                    // Using sendgrid template  -------------------------------------------------------------------------------------------------

                    var sendGridClient = new SendGridClient(_settings.Value.ApiKey);
                    var sendGridMessage = new SendGridMessage();
                    sendGridMessage.SetFrom(_settings.Value.Email, _settings.Value.Name);
                    sendGridMessage.AddTo(user.Email);
                    sendGridMessage.SetTemplateId(_settings.Value.TemplateId);
                    sendGridMessage.SetTemplateData(new
                    {
                        Link = url + "?token=" + token
                    });
                    var response = await sendGridClient.SendEmailAsync(sendGridMessage);
                }
                return user;
            }

            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }


    }
}