﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Edura.WebUI.IdentityCore;
using Edura.WebUI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Edura.WebUI.Controllers
{
    [Authorize]//yetkisiz kullanıcıların görememsi için tanımlandı
    public class AccountController : Controller
    {
        private UserManager<ApplicationUser> userManager;
        private SignInManager<ApplicationUser> signInManager;

        public AccountController(UserManager<ApplicationUser> _userManager, SignInManager<ApplicationUser> _signInManager)
        {
            userManager = _userManager;
            signInManager = _signInManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous] //login sayfasını tüm kullanıcılar görebilir
        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;

            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model,string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = await userManager.FindByEmailAsync(model.Email);

                if (user!=null)
                {
                    await signInManager.SignOutAsync();

                    var result = await signInManager.PasswordSignInAsync(user, model.Password, false, false);

                    if (result.Succeeded)
                    {
                        return Redirect(returnUrl ?? "/");
                    }
                }

                ModelState.AddModelError(nameof(model.Email), "Hatalı kullanıcı adı ya da parola");
            }

            return View();
        }

        //logout
        public async Task<IActionResult>Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}