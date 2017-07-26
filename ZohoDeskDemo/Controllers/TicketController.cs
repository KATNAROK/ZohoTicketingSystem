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

        public ActionResult PostTicket()
        {//Should the ticket processing be handled like this?
            var createResponse = new TicketCreator();
            var response = createResponse.TicketPostResponse();
            return Content(response, "application/json");
        }
    }
}