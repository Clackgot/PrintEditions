using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintEditionLib
{
    /// <summary>
    /// Журнал
    /// </summary>
    public class Magazine : PrintEdition
    {
        /// <summary>
        /// Номер выпуска
        /// </summary>
        public int Issuance { get; set; }
        /// <summary>
        /// Тип журнала
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// Основная тема журнала
        /// </summary>
        public string Topic { get; set; }


        /// <summary>
        /// Номер журнала нечётный
        /// </summary>
        /// <returns></returns>
        public bool IsIssuanceOddNumber()
        {
            return (Issuance % 2 == 1);
        }

        /// <summary>
        /// Журнал еженедельный
        /// </summary>
        /// <returns></returns>
        public bool IsMonthlyType()
        {
            return Type.ToLowerInvariant() == "ежемесячный";
        }
        /// <summary>
        /// Тема журнала про автомобили или про спорт
        /// </summary>
        /// <returns></returns>
        public bool IsSportOrCarTopic()
        {
            if (Type.ToLowerInvariant() == "спортивная" || Type.ToLowerInvariant() == "автомобильная") return true;
            else return false;
        }
        /// <summary>
        /// Конструтор класса
        /// </summary>
        /// <param name="issuance">Номер выпуска</param>
        /// <param name="type">Тип журнала</param>
        /// <param name="topic">Основная тема журнала</param>
        public Magazine(string name, int pages, int year, int issuance, string type, string topic) : base(name, pages, year)
        {
            this.Issuance = issuance;
            this.Type = type;
            this.Topic = topic;
        }


        /// <summary>
        /// Возвращает журнал как строку
        /// </summary>
        /// <returns></returns>
        public override string ToString() => base.ToString() + $"\n" +
            $"Номер выпуска: {Issuance} \n" +
            $"Тип журнала: {Type}\n" +
            $"Основная тема журнала: {Topic}";
    }
}
