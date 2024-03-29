﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Web;
using System.Web.Mvc;
using AttributeRouting.Web.Mvc;

namespace GdpSite.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

		[POST("/contato")]
		[ValidateAntiForgeryToken]
		public ActionResult Contact(string Name, string Message, string Email)
		{
			using (var smtp = new SmtpClient())
			{
				var messageBody = new StringBuilder();

				messageBody.AppendLine(string.Format("Nome: {0}", Name));
				messageBody.AppendLine(string.Format("Mensagem: {0}", Message));
				messageBody.AppendLine(string.Format("Email: {0}", Email));

				smtp.Send(new MailMessage("secretaria@gdp.arq.br", "secretaria@gdp.arq.br", "Contato Site", messageBody.ToString()));
			}

			return Json(new {success = true});
		}
    }
}
