using System;
using System.Net.Mail;
using System.Net;

public class MailSender
{


    public void SendMail(string nombre, string mail) {

        string MailOrigen = "pruebadotnet@gmail.com";
        string Contraseña = "cursocomit";
        string textoMail = 
        "<body>" +
        "<h1>Hola " + nombre + " !<h1>" +
        "<span> Recibimos tu consulta, dentro de las proximas 24Hs hábiles recibiras tu respuesta.</span>" + 
        "<span>Muchas gracias por comunicarte con nosotros.</span>";

        SmtpClient smtp = new SmtpClient("smpt.gmail.com", 587);
        smtp.Credentials = new NetworkCredential(MailOrigen, Contraseña);
        smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
        smtp.EnableSsl = true;
        smtp.UseDefaultCredentials = false;

        MailMessage mailMessage = new MailMessage();
        mailMessage.From = new MailAddress(MailOrigen, "Curso .Net ComIT");
        mailMessage.To.Add(new MailAddress(mail));
        mailMessage.Subject = "Recibimos tu consulta";
        mailMessage.IsBodyHtml = true;
        mailMessage.Body = textoMail;


        smtp.Send(mailMessage);
    }
}