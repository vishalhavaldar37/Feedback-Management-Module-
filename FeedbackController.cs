using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demo.Models;

namespace Demo.Controllers
{
    public class FeedbackController : Controller
    {
        static List<Feedback> feedbackList = new List<Feedback>();

        public ActionResult Create()
        {
            return View();
        }

        // GET: Feedback
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Feedback feedback)
        {
            feedbackList.Add(feedback);
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            return View(feedbackList);
        }
    }
}
