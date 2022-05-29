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
using OlympiadManagementSystem.Data.Services.Tools;

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
            [DataType(DataType.EmailAddress)]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [MinLength(2)]
            public string FirstName { get; private set; }
            public string LastName { get; private set; }
            public string Adress { get; private set; }
            public DateTime DateOfBirth { get; private set; }
            public int Gender { get; private set; }
            public string PhoneNumber { get; private set; }

            public string City { get; private set; }


            [Required]
            public int PersonalCode { get; set; }

            public static InputModel CreateBasicInfo(string email, int personalCode)
            {
                return new InputModel { Email = email, PersonalCode = personalCode };
            }

            public static InputModel CreateBasicInfo(string firstName, string lastName, string email,
                string adress, DateTime dateOfBirth, int personalCode, string phoneNumber)
            {

                var basicInfo = new InputModel
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    Adress = adress,
                    DateOfBirth = dateOfBirth,
                    PersonalCode = personalCode,
                    PhoneNumber = phoneNumber
                };

                return basicInfo;


            }
        }
    }

}