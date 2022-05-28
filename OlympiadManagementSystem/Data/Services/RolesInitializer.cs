using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OlympiadManagement.Infrastructure.IdentityModels;
using OlympiadManagementSystem.Application.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympiadManagementSystem.Data.Services
{
    public class RolesInitializer
    {

        public static async Task CreateRoles(IServiceCollection serviceProvider, IConfiguration configuration)
        {
            //initializing custom roles 
            var RoleManager = serviceProvider.BuildServiceProvider().GetRequiredService<RoleManager<AppRole>>();
            var UserManager = serviceProvider.BuildServiceProvider().GetRequiredService<UserManager<AppUser>>();


            IdentityResult roleResult;



            foreach (var roleName in Roles.RoleList)
            {
                var roleExist = await RoleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {

                    roleResult = await RoleManager.CreateAsync(new AppRole { Name = roleName });
                }
            }




            //Here you could create a super user who will maintain the web app

            

            var poweruser = new AppUser
            {

                UserName = configuration["AppSettings:SuperAdminCredentials:UserName"],
                Email = configuration["AppSettings:SuperAdminCredentials:UserEmail"],
            };
            //Ensure you have these values in your appsettings.json file
            string userPWD = configuration["AppSettings:SuperAdminCredentials:UserPassword"];
            var _user = await UserManager.FindByEmailAsync(configuration["AppSettings:SuperAdminCredentials:UserEmail"]);

            if (_user == null)
            {
                var createPowerUser = await UserManager.CreateAsync(poweruser, userPWD);
                if (createPowerUser.Succeeded)
                {
                    //here we tie the new user to the role
                    await UserManager.AddToRoleAsync(poweruser, "SuperAdmin");

                }
            }
        }



    }
}
