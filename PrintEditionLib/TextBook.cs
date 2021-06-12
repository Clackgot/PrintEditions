using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintEditionLib
{
    public class TextBook : PrintEdition    // учебник
    {
        /// <summary>
        /// Учебный предмет 
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// Автор
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Рецензатор
        /// </summary>
        public string Reviewer { get; set; }


        /// <summary>
        /// Автор Перышкин?
        /// </summary>
        /// <returns></returns>
        public bool IsPeryshin()
        {
            return Author.ToLowerInvariant() == "пёрышкин" || Author.ToLowerInvariant() == "перышкин";
        }

        /// <summary>
        /// Это учебник по гуманитарным наукам
        /// </summary>
        /// <returns></returns>
        public bool IsHumanitarianSubject()
        {
            string _subject = Subject.ToLower();
            if (_subject == "русский язык" ||
                _subject == "литература" ||
                _subject == "история" ||
                _subject == "обществознание" ||
                _subject == "английский язык") return true;
            else return false;
        }

        /// <summary>
        /// Имя автора короче 8 символов
        /// </summary>
        /// <returns></returns>
        public bool IsReviewerEqualAuthor()
        {
            return Author.Count() < 8;
        }

        /// <summary>
        /// Конструтор класса учебник
        /// </summary>
        /// <param name="subject">Предмет</param>
        /// <param name="author">Автор</param>
        /// <param name="reviewer">Рецензатор</param>
        public TextBook(string name, int pages, int year, string subject, string author, string reviewer) : base(name, pages, year)
        {
            this.Subject = subject;
            this.Author = author;
            this.Reviewer = reviewer;
        }


        /// <summary>
        /// Возвращает учебник как строку
        /// </summary>
        /// <returns></returns>
        public override string ToString() => base.ToString() + $"\n" +
            $"Предмет: {Subject} \n" +
            $"Автор: {Author}\n" +
            $"Рецензатор: {Reviewer}";
    }
}
