using System.Data.Entity;

namespace DAL.Entities
{
    public class BlogContext:DbContext
    {
        static BlogContext()
        {
            Database.SetInitializer<BlogContext>(new MyContextInitializer());
        }
        public DbSet<ArticleD> Articles { get; set; }
        public DbSet<FeedbackD> Feedbacks { get; set; }
    }
}
