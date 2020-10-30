using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Grupo_Form.Models;

namespace MVC_Grupo_Form.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Contacto(){
            return View();
        }

    

        [HttpPost]
        public IActionResult EnviarContacto(string nombre, string mail, string consulta) {


                try
                {
                    MailMessage correo= new MailMessage();
                    correo.From=new MailAddress("grupo1comit@gmail.com");
                    correo.To.Add(mail);
                    correo.Body= consulta;
                    correo.IsBodyHtml= true;
                    correo.Priority= MailPriority.Normal;
                    SmtpClient smtp= new SmtpClient();
                    smtp.Host= "smtp.gmail.com";
                    smtp.Port=25;
                    smtp.EnableSsl=true;
                    smtp.UseDefaultCredentials=true;
                    string scuentaCorreo="grupo1comit@gmail.com";
                    string sPasswordCorreo="grupo1com";
                    smtp.Credentials= new System.Net.NetworkCredential(scuentaCorreo,sPasswordCorreo);
                    smtp.Send(correo);
                    ViewBag.Mensaje= "Mensaje enviado correctamente";

                }
                catch (Exception ex)
                {
                    
                    ViewBag.Error= ex.Message;
                }

            this.ViewBag.Nombre = nombre;
            this.ViewBag.Mail = mail;
            this.ViewBag.Consulta = consulta;
            
        
            return View("ConsultaEnviada");
        }
    }
}
