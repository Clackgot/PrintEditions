namespace PrintEditionLib
{
    public class Book : PrintEdition    // книга
    {
        /// <summary>
        /// Жанр
        /// </summary>
        public string Genre { get; set; }
        /// <summary>
        /// Автор
        /// </summary>
        public string Author { get; set; }
        /// <summary>
        /// Издательство
        /// </summary>
        public string PublishingHouse { get; set; }


        /// <summary>
        /// Книга научного или фанатстического жанра
        /// </summary>
        /// <returns></returns>
        public bool IsScientificOrFantasticGenre()
        {
            return Genre.ToLowerInvariant() == "научный" || Genre.ToLower() == "фантастика";
        }

        /// <summary>
        /// Автор книги Азимов
        /// </summary>
        /// <returns></returns>
        public bool IsAzimov()
        {
            return Author.ToLowerInvariant() == "азимов";
        }

        /// <summary>
        /// Название издательства палиндром
        /// </summary>
        /// <returns></returns>
        public bool PublishingHouseNameIsPalindrome()
        {
            string word = PublishingHouse.ToLowerInvariant();


            for (int first = 0, last = word.Length - 1; first < last; ++first, --last)
            {
                if (word[first] != word[last])
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="genre">Жанр</param>
        /// <param name="author">Автор</param>
        /// <param name="publishingHouse">Издательство</param>
        public Book(string name, int pages, int year, string genre, string author, string publishingHouse) : base(name, pages, year)
        {
            this.Genre = genre;
            this.Author = author;
            this.PublishingHouse = publishingHouse;
        }

        /// <summary>
        /// Возвращает книгу как строку
        /// </summary>
        /// <returns></returns>
        public override string ToString() => base.ToString() + $"\n" +
            $"Жанр: {Genre} \n" +
            $"Автор: {Author}\n" +
            $"Издательство: {PublishingHouse}";

    }
}
