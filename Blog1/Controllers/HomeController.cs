using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using Blog.Models;
using Blog1.Models;
using DAL.Repositories;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        private static readonly Voting Voting=new Voting();
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

        public ViewResult GetArticle(int id)
        {
            ArticleR articleR=new ArticleR();
            var temp= articleR.Find(id);
            ArticleViewModel articleViewModel = new ArticleViewModel
            {
                Title = temp.Title,
                Text = temp.Text,
                Time = temp.Time,
                HashTags = ""
            };
            //temp.Text = "Как часто хочется совместить синемагарфию с текстом, красивые фотоэффекты с заголовками и прочее. Но задумайтесь о своей аудитории. Например, посетитель блога не ждет увидеть иллюстрированию книгу и он очень расстроится, если обнаружит текст релиза в две строки.#Разнообразие, вот еще один #фактор-баланса текста и графики. По опыту веб-мастера уже знают, что сработает для аудитории, а что нет. Или просто представляют себя на их месте.Проект intours-dmc обладает визуально большим количеством текста (#набор-слов), чем графики. Но зато их анимационные эффекты добавляют пикантности и позволяют комфортнее изучать сайт. Таким образом, малое количество изображений они компенсировали всплывающими элементами. Появляющимися и исчезающими инфоблоками и красивыми фотографиями балерин.";
            //articleR.Update(3,temp);
            foreach (var find in Regex.Matches(temp.Text, "#[А-ЯЁA-Z-]+",RegexOptions.IgnoreCase))
            {
                articleViewModel.HashTags += find+",";
            }

            ViewBag.Article = articleViewModel;
            return View();
        }

        public ViewResult Vote(string vote)
        {
            if (vote == "like") Voting.Like++;
            else Voting.DontLike++;
            return View(Voting);
        }

        public ViewResult GetArticles(string h)
        {
            ArticleR articleR = new ArticleR();
            var temp = articleR.GetAll();
            var art = temp.Where(a => a.Text.Contains(h));
            ViewBag.Articles = art;
            return View("Index");
        }
    }
}