using System.Collections.Generic;
using System.Linq;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class ArticleR:IRepository<ArticleD>
    {
        public IEnumerable<ArticleD> GetAll()
        {
            BlogContext db = new BlogContext();
            return db.Articles.ToList();
        }

        public void Create(ArticleD item)
        {
            BlogContext db = new BlogContext();
            db.Articles.Add(new ArticleD {Text = item.Text, Time = item.Time, Title = item.Title});
            db.SaveChanges();
            db.Dispose();
        }

        public ArticleD Find(int id)
        {
            BlogContext db = new BlogContext();
            return db.Articles.Find(id);
        }

        public void Update(int id, ArticleD articleD)
        {
            BlogContext db = new BlogContext();
            ArticleD article = db.Articles.Find(id);
            article.Text = articleD.Text;
            db.SaveChanges();
        }
    }
}
