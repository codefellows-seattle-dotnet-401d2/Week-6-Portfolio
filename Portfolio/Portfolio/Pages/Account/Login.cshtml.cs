using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Portfolio.Pages.Account
{
    public class LoginModel : PageModel
    {
        [BindProperty]
        [Required]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }



        public IActionResult OnPost()
        {
            var isValidUser = EmailAddress == "dre@codefellows.com" && Password == "nyc";

            if (!isValidUser)
            {
                ModelState.AddModelError("", "Invalid Email or Password");
                return Page();
            }

            //using authentication 
            var scheme = CookieAuthenticationDefaults.AuthenticationScheme;

            var user = new ClaimsPrincipal(
                new ClaimsIdentity(
                    new[] { new Claim(ClaimTypes.Name, EmailAddress) }
                    )
                  );

            return SignIn(user, scheme);

        }
    }
}