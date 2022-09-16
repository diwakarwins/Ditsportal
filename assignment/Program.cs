using Domain.Data;
using DitsPortal_Repository.Repository;
using DitsPortal_Repository.IRepository;
using DitsPortal_Service.IService;
using DitsPortal_Service.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using DitsPortal.Common.StaticResource;


using SendGrid.Extensions.DependencyInjection;

using DitsPortal.Common.Requests;
using SendGrid;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var appSettingsSection = builder.Configuration.GetSection("AppSettings");
builder.Services.Configure<AppSettings>(appSettingsSection);

// var appSettings = appSettingsSection.Get<AppSettings>();
// var key = Encoding.ASCII.GetBytes(appSettings.ApiKey);


// using IHost host = Host.CreateDefaultBuilder(args)
//     .ConfigureServices((context, services) =>
//     {
//         services.AddSendGrid(options =>
//             options.ApiKey = context.Configuration["ApiKey"]
//         );
//         services.Configure<EmailOptions>(context.Configuration.GetSection("Email"));
//         // services.AddTransient<EmailSender>();
//     })
//     .Build();

// var emailSender = host.Services.GetRequiredService<UserRepository>();
// await emailSender.SendEmail();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = builder.Configuration.GetConnectionString("connectionDB");
builder.Services.AddDbContext<ApplicationDBContext>(options =>
options.UseSqlServer(connection), ServiceLifetime.Transient);
// service
// builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IGlobalCodeCategoriesService, GlobalCodeCategoriesService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IGlobalCodesService, GlobalCodesService>();

//repository

builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddControllersWithViews();

// builder.Services.AddTransient<IUserRepository, UserRepository>();
builder.Services.AddTransient<IGlobalCodeCategoriesRepository, GlobalCodeCategoriesRepository>();
builder.Services.AddTransient<IGlobalCodesRepository, GlobalCodesRepository>();
builder.Services.AddTransient<IUserRepository, UserRepository>();



builder.Services.AddControllers();
builder.Services.AddSwaggerGen(c =>
           {
               c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
               c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
               {
                   Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
                   Name = "Authorization",
                   In = ParameterLocation.Header,
                   Type = SecuritySchemeType.ApiKey,
                   Scheme = "Bearer"
               });
               c.AddSecurityRequirement(new OpenApiSecurityRequirement()
               {
                {
                    new OpenApiSecurityScheme
                    {
                    Reference = new OpenApiReference
                        {
                        Type = ReferenceType.SecurityScheme,
                        Id = "Bearer"
                        },
                        Scheme = "oauth2",
                        Name = "Bearer",
                        In = ParameterLocation.Header,

                    },
                    new List<string>()
                    }
               });

           });



builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.RequireHttpsMetadata = false;
    options.SaveToken = true;
    options.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["Jwt:Audience"],
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    };
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
