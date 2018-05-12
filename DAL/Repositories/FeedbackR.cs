using System.Collections.Generic;
using System.Linq;
using DAL.Entities;
using DAL.Interfaces;

namespace DAL.Repositories
{
    public class FeedbackR:IRepository<FeedbackD>
    {
        public IEnumerable<FeedbackD> GetAll()
        {
            BlogContext db = new BlogContext();
            return db.Feedbacks.ToList();
        }

        public void Create(FeedbackD item)
        {
            BlogContext db = new BlogContext();
            db.Feedbacks.Add(new FeedbackD {Author = item.Author, Date = item.Date, Text = item.Text});
            db.SaveChanges();
        }
    }
}
