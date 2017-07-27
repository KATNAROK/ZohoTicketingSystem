using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZohoDeskDemo.Models;

namespace ZohoDeskDemo.Controllers
{
    public class TicketController : Controller
    {
        // GET: Ticket
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TicketCreator()
        {
            return View();
        }

        public ActionResult PostTicket(String Subject, String Email)
        {//Should the ticket processing be handled like this?
            var formManager = new FormDetails(Subject, Email);

            var createResponse = new TicketManager();
            var response = createResponse.TicketPostResponse(formManager);
            return Content(response, "application/json");
        }
    }
}