using SendGrid.Transport;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace AnthonysGraduating.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Directions()
        {
            //SendGrid.Mail message = SendGrid.Mail.GetInstance();
            //MailAddress from = new MailAddress("noreply@anthonysgraduating.com");
            //message.From = from;
            //message.AddTo("karl.a.james@hotmail.com");
            //message.Html = "<p>Hello World</p>";
            //message.Subject = "SendGrid Hello World";

            //var credentials = new NetworkCredential("azure_886476f1273c52bd47c9c1185033337a@azure.com", "ormyen5i");
            //var transport = SMTP.GetInstance(credentials);
            //transport.Deliver(message);

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult CommencementOnline()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}