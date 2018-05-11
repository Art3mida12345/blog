using System.Web.Mvc;
using DAL.Repositories;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// <c>Index</c> is a method in the <c>HomeController</c>.
        /// It post articles on the page from DB.
        /// </summary>
        public ViewResult Index()
        {
            ArticleR articleR = new ArticleR();
            ViewBag.Articles = articleR.GetAll();
            return View();
        }
    }
}