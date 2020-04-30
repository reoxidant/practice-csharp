using System;

namespace bk_2_cinema_adviser
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Эта программа поможет подобрать Вам фильм для вечернего просмотра под Ваше настроение! Вперёд?");
            Console.WriteLine("Как вас зовут?");
            String name = Console.ReadLine();
            Console.WriteLine("Здравствуйте, " + name);
            Console.WriteLine("Фильм какого жанра вы бы хотели посмотреть: комедия, драма, фантастика, триллер, боевик?");
            String genre = Console.ReadLine();

            Console.WriteLine("Отличный Выбор. Cоветую посмотреть следующие фильмы: ");

            if(genre == "комедия")
            {
                Console.WriteLine("Какой фильм вам бы сейчас больше хотелось посмотреть: отечественный или зарубежный");
                String country = Console.ReadLine();
                if(country == "отечетвенный")
                {
                    Console.WriteLine("В таком случае, рекомендую посмотреть следующие фильмы:");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*** Операция Ы");
                    Console.WriteLine("*** Иван Васильевич меняет профессию");
                }
                else
                {
                    Console.WriteLine("В таком случае, рекомендую посмотреть следующие фильмы:");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("*** Назад в будующее");
                    Console.WriteLine("*** В джазе только девушки");
                }         
            }
            else if(genre == "фантастика")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*** Черепашки ниндзя");
                Console.WriteLine("*** Люди икс");
            }
            else if (genre == "триллеры")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*** Леон");
                Console.WriteLine("*** Бойцовский Клуб");
            }
            else if (genre == "боевики")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*** Матрица");
                Console.WriteLine("*** Темный рыцарь");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*** Зеленая миля");
                Console.WriteLine("*** Побег из шоушенга");
                Console.WriteLine("*** Хатико");
                Console.WriteLine("*** Титаник");
                Console.WriteLine("*** Гарри Поттер");
            }
            Console.ReadLine();
        }
    }
}
