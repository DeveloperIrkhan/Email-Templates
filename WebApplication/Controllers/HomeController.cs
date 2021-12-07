using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        #region Identity Owner
      
        public IActionResult OwnerEmail()
        {
            return View();
        }
        public IActionResult OwnerSuccess()
        {
            return View();
        }
        public IActionResult OwnerUnsuccessful()
        {
            return View();
        }
        public IActionResult OwnerReusingexisting()
        {
            return View();
        }
        #endregion

        #region Tenant Admin
        public IActionResult TenantAuthCode()
        {
            return View();
        }
        public IActionResult TenantResetPassword()
        {
            return View();
        }
        public IActionResult TenantSuccessfulVerificaiton()
        {
            return View();
        }
        public IActionResult TenantUnsuccessfulVerification()
        {
            return View();
        }
        public IActionResult TenantPartialSuccessfulVerification()
        {
            return View();
        }
        #endregion

        #region IDUX Admin
        public IActionResult IDUXAuthenticationCode()
        {
            return View();
        }
        public IActionResult IDUXResetPassword()
        {
            return View();
        }
        #endregion

    }
}
