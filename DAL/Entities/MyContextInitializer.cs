﻿using System;
using System.Data.Entity;

namespace DAL.Entities
{
    public class MyContextInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext db)
        {
            ArticleD a1=new ArticleD
            {
                Title = "Текст-рыба",
                Time = DateTime.Today,
                Text = "Каждый веб-разработчик знает, что такое #текст-рыба. Текст этот, несмотря на название, не имеет никакого отношения к обитателям водоемов. Используется он веб-дизайнерами для вставки на интернет-страницы и демонстрации внешнего вида контента, просмотра шрифтов, абзацев, отступов и т.д. Так как цель применения такого текста исключительно демонстрационная, то и смысловую нагрузку ему нести совсем необязательно. Более того, нечитабельность текста сыграет на руку при оценке качества восприятия макета.Самым известным «рыбным» текстом является знаменитый #Lorem-ipsum. Считается, что впервые его применили в книгопечатании еще в XVI веке. Своим появлением Lorem ipsum обязан древнеримскому философу Цицерону, ведь именно из его трактата «О пределах добра и зла» средневековый книгопечатник вырвал отдельные фразы и слова, получив текст-«рыбу», широко используемый и по сей день. Конечно, возникают некоторые вопросы, связанные с использованием Lorem ipsum на сайтах и проектах, ориентированных на кириллический контент – написание символов на латыни и на кириллице значительно различается.И даже с языками, использующими латинский алфавит, могут возникнуть небольшие проблемы: в различных языках те или иные буквы встречаются с разной частотой, имеется разница в длине наиболее распространенных слов. Отсюда напрашивается вывод, что все же лучше использовать в качестве «рыбы» текст на том языке, который планируется использовать при запуске проекта. Сегодня существует несколько вариантов Lorem ipsum, кроме того, есть специальные генераторы, создающие собственные варианты текста на основе оригинального трактата, благодаря чему появляется возможность получить более длинный неповторяющийся #набор-слов."
            };
            ArticleD a2 = new ArticleD
            {
                Title = "Web&Balance",
                Time = DateTime.Today.AddDays(-5),
                Text = "Достижение баланса в вебе-дизайне это и усилия, и мастерство, и многочасовые размышления, и, разумеется, опыт. В большинстве случаев, основной момент, характеризующий #баланс – отсутствие перегрузки, исключение беспорядка. Это то, что служит пользовательскому опыту. То, что позволяет посетителям чувствовать себя комфортно на том или ином сайте. #Баланс-в-веб-дизайне создает гармонию во всей конструкции проекта и одновременно поражает своим удобством и функциональной простотой.Мы уже рассматривали вопросы работы с пространством, текстом, графикой. Но сегодня решили поразмышлять и поискать идеи интересных вариантов сбалансированного сочетания текста и изображений/фотографий. Чтобы при взгляде на тот или иной сайт приходила мысль: всего этого не слишком много и не слишком мало; не слишком ярко и не слишком уныло.Визуальная составляющая обрабатывается быстрее, но текст способствует глубокому пониманию информации. Именно поэтому в веб-дизайне так важен баланс сочетания текста и графики для #обеспечения-посетителей лучшим контентом и оправданием их ожиданий."
            };
            ArticleD a3 = new ArticleD
            {
                Title = "Эффекты и текст",
                Time = DateTime.Today,
                Text = "Как часто хочется совместить синемагарфию с текстом, красивые фотоэффекты с заголовками и прочее. Но задумайтесь о своей аудитории. Например, посетитель блога не ждет увидеть иллюстрированию книгу и он очень расстроится, если обнаружит текст релиза в две строки.#Разнообразие, вот еще один #фактор-баланса текста и графики. По опыту веб-мастера уже знают, что сработает для аудитории, а что нет. Или просто представляют себя на их месте.Проект intours-dmc обладает визуально большим количеством текста (#набор-слов), чем графики. Но зато их анимационные эффекты добавляют пикантности и позволяют комфортнее изучать сайт. Таким образом, малое количество изображений они компенсировали всплывающими элементами. Появляющимися и исчезающими инфоблоками и красивыми фотографиями балерин."
            };

            db.Articles.Add(a1);
            db.Articles.Add(a2);
            db.Articles.Add(a3);

            FeedbackD f1 = new FeedbackD { Author = "Author 1", Date = DateTime.Now, Text = "Text" };
            FeedbackD f2 = new FeedbackD { Author = "Author 2", Date = DateTime.Now, Text = "Text" };
            FeedbackD f3 = new FeedbackD { Author = "Author 3", Date = DateTime.Now, Text = "Text" };
            FeedbackD f4 = new FeedbackD { Author = "Author 4", Date = DateTime.Now, Text = "Text" };
            FeedbackD f5 = new FeedbackD { Author = "Author 5", Date = DateTime.Now, Text = "Text" };
            FeedbackD f6 = new FeedbackD { Author = "Author 6", Date = DateTime.Now, Text = "Text" };

            db.Feedbacks.Add(f1);
            db.Feedbacks.Add(f2);
            db.Feedbacks.Add(f3);
            db.Feedbacks.Add(f4);
            db.Feedbacks.Add(f5);
            db.Feedbacks.Add(f6);

            db.SaveChanges();
        }
    }
}
