using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdminASPNETcoreMVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> Login(LoginViewModel model String returnUrl)
        {
            if(ModelState.IsValid)
            {
                var result = await signInManager.PasswordSingInAsync(model.Email, model.Password, model.rememberMe, false);
                if(result.Succeeded)
                {
                    if(!String.IsNullOrEmpty(returnUrl))
                    {
                        return Redirect(returnUrl);
                    }
                    else
                    {
                        return RedirectToAction("index", "home");
                    }
                }
            }
            return View(model);
        }

    }
}