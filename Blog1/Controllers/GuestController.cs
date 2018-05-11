using System;
using System.Web.Mvc;
using DAL.Entities;
using DAL.Repositories;

namespace Blog.Controllers
{
    public class GuestController : Controller
    {
        /// <summary>
        /// <c>GuestIndex</c> is a method in the <c>GuestController</c>.
        /// It load feedbacks from DB.
        /// </summary>
        public ViewResult GuestIndex()
        {
            FeedbackR feedbackR = new FeedbackR();
            ViewBag.Feedbacks = feedbackR.GetAll();
            return View("GuestIndex");
        }

        /// <summary>
        /// <c>Post</c> is a method in the <c>GuestController</c>.
        /// It post feedback on the page and add it to the DB.
        /// </summary>
        public ViewResult Post(FeedbackD feedback)
        {
            FeedbackR feedbackR = new FeedbackR();
            feedback.Date = DateTime.Now;
            feedbackR.Create(feedback);
            ViewBag.Feedbacks = feedbackR.GetAll();
            return View("GuestIndex");
        }
    }
}