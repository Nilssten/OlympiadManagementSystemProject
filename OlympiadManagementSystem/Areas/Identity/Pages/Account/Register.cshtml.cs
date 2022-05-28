using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OlympiadManagement.Core.Aggregates.EducationAggregate;
using OlympiadManagement.Core.Aggregates.UserProfileAggregate;
using OlympiadManagement.Infrastructure.IdentityModels;
using OlympiadManagementSystem.Application.Enums;
using OlympiadManagementSystem.Data.Services.DomainServices;

namespace OlympiadManagementSystem.Areas.Identity.Pages.Account
{
    public partial class Registration : PageModel
    {

        private  UserManager<AppUser> _userManager;
        private  SignInManager<AppUser> _signInManager; 
        private  IApplicantService _applicantService;

        public Registration(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager
             , IApplicantService applicantService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _applicantService = applicantService;
            

        }

        [BindProperty] public InputModel Input { get; set; }
        public string ReturnUrl { get; set; }





        public void OnGet()
        { }

        public async Task<IActionResult> OnPostAsync()
        {
            ReturnUrl = Url.Content("~/");
            if (ModelState.IsValid)
            {
                var identity = new AppUser { UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(identity, Input.Password);
                //var claim = new Claim("role", Input.Role);
                var roleResult = await _userManager.AddToRoleAsync(identity, Roles.APPLICANT);
                if (result.Succeeded && roleResult.Succeeded)
                {
                    var userProfile = UserProfile.CreateUserProfile(BasicInfo.CreateBasicInfo(Input.Email, Input.PersonalCode));
                   


                    //TODO:: change school hardcoded data
                    await _applicantService.CreateApplicantAsync(
                            Applicant.CreateApplicant("High pedagogic", userProfile,
                                School.CreateSchool("Riga iela 3 ", "12vsk", "Tukums", "Tukums")));



                    await _signInManager.SignInAsync(identity, isPersistent: false);
                    return LocalRedirect(ReturnUrl);
                }
            }

            return Page();


        }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            //[Required]
            //public string Role { get; set; }

            [Required]
            public int PersonalCode { get; set; }
        }
    }
}