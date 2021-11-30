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
        public IActionResult Verify()
        {
            return View();
        }
        public IActionResult Success()
        {
            return View();
        }
        public IActionResult Unsuccessful()
        {
            return View();
        }
        public IActionResult Reusingexisting()
        {
            return View();
        }
        #endregion

        #region Tenant Admin
        public IActionResult authenticationCode()
        {
            return View();
        }
        public IActionResult ResetPassword()
        {
            return View();
        }
        public IActionResult AdminSuccessfullVerificaiton()
        {
            return View();
        }
        public IActionResult AdminUnsuccessfulVerification()
        {
            return View();
        }
        public IActionResult PartialSuccessfulVerification()
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
