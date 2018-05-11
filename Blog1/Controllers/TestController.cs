using System.Web.Mvc;
using Blog.Models;

namespace Blog.Controllers
{
    public class TestController : Controller
    {
        public ViewResult TestView()
        {
            return View("TestView");
        }
        /// <summary>
        /// <c>Check</c> is a method in the <c>TestController</c>.
        /// <para>It returns <c>OkView</c> if method is GET or <c>TestView</c> if method is POST.</para>
        /// <para>OkView view information, that was sent from <c>TestView</c></para>
        /// </summary>
        public ActionResult Check(FormData formd)
        {
            if (HttpContext.Request.HttpMethod == "GET")
            {
                return View("OkView", formd);
            }
            if (HttpContext.Request.HttpMethod == "POST")
                return View("TestView");
            return HttpNotFound();
        }
    }
}