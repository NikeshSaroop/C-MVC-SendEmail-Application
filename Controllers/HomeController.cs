using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WarpDevelopmentTest.Models;


namespace WarpDevelopmentTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

           
            return View();
            
        }

        
      





        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult SendEmail()
        {
            return View();
        }


        [HttpPost]
        public  ActionResult SendEmail(string receiver, string subject, string message)
        {
            
            try
            {
                if (ModelState.IsValid)
                {
                    
                    var senderEmail = new MailAddress("Enter Sender email address here!!!", "Confirmation");
                    var toAddress = ConfigurationManager.AppSettings["EmailToAddress"];
                    var receiverEmail = new MailAddress(toAddress, "Receiver");
                    var sub = subject;
                    var body = message;
                    

                    using (var mess = new MailMessage(senderEmail, receiverEmail)
                    {
                        Subject = subject,
                        Body = body
                    })

                    using (var smtp = new SmtpClient())
                    {
                        
                        smtp.Send(mess);
                      
                    }
                    return RedirectToAction("Index","Details");


                }
            }
            catch (Exception)
            {
                ViewBag.Error = "Some Error";
            }
            return View();
        }


    }
}