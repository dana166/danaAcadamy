using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var userSarvices = new UserSarvices();
            userSarvices.Add(new AddUserRequst()
            {

                FullName = "dana",
                EmailAddress = "dana35112_2@icloud.com",
                Password = "102030",
                Address = "amman",
            });


            var res1 = userSarvices.Login(emailAddress: "dana35112_2@icloud.com", password: "102030");

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
