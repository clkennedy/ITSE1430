using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EventPlanner.Mvc.App_Start;

namespace EventPlanner.Mvc.Controllers
{
    public class EventController : Controller
    {
        // GET: Event
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult My()
        {
            List<ScheduledEvent> _events = DatabaseFactory.Database.GetAll(new EventCriteria()
                                                                                    { IncludePrivate = true,
                                                                                      IncludePublic = false }).ToList();

            List<ScheduledEventModel> _modelEvents = new List<ScheduledEventModel>();

            _events.ForEach(evt => _modelEvents.Add(new ScheduledEventModel(evt)));

            return View(_modelEvents);
        }

    }
}