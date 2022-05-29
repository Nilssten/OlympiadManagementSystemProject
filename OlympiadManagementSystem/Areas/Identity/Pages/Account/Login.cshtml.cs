using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OlympiadManagement.Infrastructure.IdentityModels;

namespace OlympiadManagementSystem.Areas.Identity.Pages.Account
{
    public class LoginModel : PageModel
    {

   

        private readonly SignInManager<AppUser> _signInManager;

        public LoginModel(SignInManager<AppUser> signInManager)
        {

            _signInManager = signInManager;
        }


        [BindProperty] public InputModel Input { get; set; }
        public string ReturnUrl { get; set; }


        public void OnGet()
        {
            ReturnUrl = Url.Content("~/");

        }

        public async Task<IActionResult> OnPostAsync()
        {

            ReturnUrl = Url.Content("~/");
            if (ModelState.IsValid)
            {
                
                var result = await _signInManager.PasswordSignInAsync
                    (Input.UserName, Input.Password, isPersistent:false, lockoutOnFailure: false);
                if (result.Succeeded) return LocalRedirect(ReturnUrl);
            }

            return Page();



        }


        public class InputModel
        {
            [Required]
            public string UserName { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }
        }
    }
}