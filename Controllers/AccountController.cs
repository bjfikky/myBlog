﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Blog.Controllers
{
    public class AccountController : Controller
    {
        protected ApplicationDbContext _context;
        protected UserManager<ApplicationUser> _userManager;
        protected SignInManager<ApplicationUser> _signInManager;

        public AccountController (
            ApplicationDbContext context, 
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager )    
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: /<controller>/
        
        public async Task<IActionResult> Register() {
            var result = await _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "bjfikky",
                Email = "bjfikky@yahoo.com"
            }, "Fikky007&");

            return result.Succeeded ? Content("User created", "text/html") : Content("User creation failed", "text/html");
        }

    }
}
