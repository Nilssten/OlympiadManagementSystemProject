using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace OlympiadManagementSystem.Areas.Identity.Pages.Account
{
    public partial class Registration : PageModel
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;

        public Registration(UserManager<IdentityUser> userManager , SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;

        }

        [BindProperty] public InputModel Input { get; set; }
        public string ReturnUrl { get; set; }


        


        public void OnGet()
        { }

        public async Task<IActionResult> OnPostAsync()
        {
            ReturnUrl = Url.Content("~/");
            if (!ModelState.IsValid)
            {
                var identity = new IdentityUser { UserName = Input.Email, Email = Input.Email };
                var result = await _userManager.CreateAsync(identity, Input.Password);

                if (result.Succeeded)
                {
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
        }
    }
}
