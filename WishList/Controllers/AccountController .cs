
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity ;
using WishList.Models ;
using Microsoft.AspNetCore.Authorization;

namespace WishList.Controllers
{
    [Authorize]
    public class AccountController  : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public AccountController (UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager)
        {
            _userManager= userManager;
            _signInManager =signInManager;
        }      
    }
}