using PrintEditionLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintEditionsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PrintEdition> items = new List<PrintEdition>();    // список объектов

            while (true)
            {
                Console.Clear();
                string menu = "1.Просмотр печатных изданий\n2.Добавить печатное издание\n3.Удалить печатное издание\n4.Выход";
                Console.WriteLine(menu);    // вывод меню

                if (!int.TryParse(Console.ReadLine(), out int answer))      // отлов ошибок ввода с консоли
                {
                    Console.WriteLine("Неверный вариант\n");
                }
                else
                {
                    switch (answer)
                    {
                        case 1:     // Просмотр элементов
                            if (items.Count != 0)
                            {
                                int id = 1;
                                Console.Clear();
                                foreach (var el in items) // вывод элементов списка
                                {
                                    Console.Write("\t№" + id + ".\n-----------------------------\n");
                                    Console.WriteLine(el);
                                    Console.WriteLine("\n-----------------------------\n");
                                    id++;
                                }
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Список пуст\n");
                                Console.ReadLine();
                            }
                            break;

                        case 2:     // Добавление печатного издания
                            Console.Clear();
                            Console.WriteLine("1.Книга\n2.Журнал\n3.Учебник\n");

                            if (!int.TryParse(System.Console.ReadLine(), out int item))
                                Console.WriteLine("Неверный вариант\n");
                            else
                            {
                                switch (item)
                                {
                                    case 1: // Книга Book
                                        string name;
                                        int pages;
                                        int year;

                                        Console.Clear();

                                        Console.Write("Название: ");
                                        name = Console.ReadLine(); // чтение данных из консоли

                                        Console.Write("Страниц: ");
                                        while (!int.TryParse(Console.ReadLine(), out pages) || pages <= 0) ; // чтение данных из консоли

                                        Console.Write("Год: ");
                                        while (!int.TryParse(Console.ReadLine(), out year)) ; // чтение данных из консоли


                                        string genre, author, publishingHouse;

                                        Console.Write("Жанр: ");
                                        genre = Console.ReadLine(); // чтение данных из консоли

                                        Console.Write("Автор: ");
                                        author = Console.ReadLine(); // чтение данных из консоли

                                        Console.Write("Издательство: ");
                                        publishingHouse = Console.ReadLine(); // чтение данных из консоли


                                        Book book = new Book(name, pages, year, genre, author, publishingHouse);
                                        items.Add(book);    // добавление элемента в список

                                        break;
                                    case 2: // Журнал Magazine
                                        Console.Clear();
                                        Console.Write("Название: ");
                                        name = Console.ReadLine(); // чтение данных из консоли


                                        Console.Write("Страниц: ");
                                        while (!int.TryParse(Console.ReadLine(), out pages) || pages <= 0); // чтение данных из консоли

                                        Console.Write("Год: ");
                                        while (!int.TryParse(Console.ReadLine(), out year)); // чтение данных из консоли


                                        int issuance;
                                        string type, topic;

                                        Console.Write("Номер выпуска: ");
                                        while (!int.TryParse(Console.ReadLine(), out issuance) || issuance <= 0) ; // чтение данных из консоли

                                        Console.Write("Тип журнала: ");
                                        type = Console.ReadLine(); // чтение данных из консоли

                                        Console.Write("Основная тема журнала: ");
                                        topic = Console.ReadLine(); // чтение данных из консоли


                                        Magazine magazine = new Magazine(name, pages, year, issuance, type, topic);
                                        items.Add(magazine);    // добавление элемента в список


                                        break;
                                    case 3: // TextBook
                                        Console.Clear();

                                        Console.Write("Название: ");
                                        name = Console.ReadLine(); // чтение данных из консоли

                                        Console.Write("Страниц: ");
                                        while (!int.TryParse(Console.ReadLine(), out pages) || pages <= 0) ; // чтение данных из консоли

                                        Console.Write("Год: ");
                                        while (!int.TryParse(Console.ReadLine(), out year)) ; // чтение данных из консоли


                                        string subject, authors, reviewer;

                                        Console.Write("\nПредмет: ");
                                        subject = Console.ReadLine();

                                        Console.Write("\nАвтор: ");
                                        authors = Console.ReadLine();

                                        Console.Write("\nРецензатор: ");
                                        reviewer = Console.ReadLine();

                                        TextBook textBook = new TextBook(name, pages, year, subject, authors, reviewer);
                                        items.Add(textBook);

                                        break;
                                }
                            }
                            break;
                        case 3:     // Удаление печатного издания
                            if (items.Count != 0)
                            {
                                int ids = 1;
                                Console.Clear();
                                foreach (var el in items)       // вывод элементов списка
                                {
                                    Console.Write("Номер " + ids + ".\n-----------------------------\n");
                                    Console.WriteLine(el);
                                    Console.WriteLine("\n-----------------------------\n");
                                    ids++;
                                }
                                Console.Write("Введите номер удаляемого печатаного издания: ");
                                int line;
                                while ((!int.TryParse(Console.ReadLine(), out line)) || line <= 0 || line > items.Count) ;
                                items.Remove(items[line - 1]);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Список пуст\n");
                                Console.ReadLine();
                            }
                            break;
                        case 4:     // Выход
                            return;
                    }

                }
            }
        }
    }
}
