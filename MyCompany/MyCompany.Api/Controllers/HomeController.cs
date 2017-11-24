using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Api.Models;
using MyCompany.Service.Services.Emails;

namespace MyCompany.Api.Controllers
{
    public class HomeController : Controller
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(HomeController));
        private readonly IEmailService _emailService;
        public HomeController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        public IActionResult Index()
        {
            var emailMessage = new EmailMessage();
            var toEmailAddress = new EmailAddress()
            {
                Name = "Nguyen Hoang Vu To",
                Address = "vu.nh@live.com"
            };
            var fromEmailAddress = new EmailAddress()
            {
                Name = "Nguyen Hoang Vu From",
                Address = "vu.nh79@yahoo.com"
            };
            emailMessage.ToAddresses.Add(toEmailAddress);
            emailMessage.FromAddresses.Add(fromEmailAddress);
            emailMessage.Subject = "Hoang Vu Test mail";
            emailMessage.Content = "send form vu.nh79 to vu.nh@live.com";
         //   _emailService.Send(emailMessage);
            log.Info("run Home index!");
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            log.Info("Error Home index!");
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
