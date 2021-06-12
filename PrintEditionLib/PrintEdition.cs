using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintEditionLib
{
    /// <summary>
    /// Базовый класс печатное издание
    /// </summary>
    public abstract class PrintEdition 
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Количество страниц
        /// </summary>
        public int PagesCount { get; set; }
        /// <summary>
        /// Год
        /// </summary>
        public int Year { get; set; }

        /// <summary>
        /// Среднее количество слов в книге
        /// </summary>
        /// <returns></returns>
        public int GetAverageWordsCount()
        {
            return PagesCount * 600;
        }

        /// <summary>
        /// Это високосный год?
        /// </summary>
        /// <returns></returns>
        public bool IsLeapYear()
        {
            if (Year % 4 != 0) return false;
            else if (Year % 100 == 0 && Year % 400 != 0) return false;
            else return true;
        }
        /// <summary>
        /// Количество букв в названии
        /// </summary>
        /// <returns></returns>
        public int GetCountLettersInName()
        {
            return Name.Length;
        }

        /// <summary>
        /// Конструтор класса печатное издание
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="pages">Страниц</param>
        /// <param name="year">Год</param>
        public PrintEdition(string name, int pages, int year)
        {
            this.Name = name;
            this.PagesCount = pages;
            this.Year = year;
        }

        /// <summary>
        /// Возвращает печатное издание как строку
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"Название: {Name}\nЧисло страниц: {PagesCount}\nГод: {Year}";


    }

}
