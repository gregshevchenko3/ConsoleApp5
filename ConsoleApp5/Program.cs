using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Author markTven = new Author("Марк", "Твен", new DateTime(1835, 11, 30), Gender.MALE, "Aмериканский писатель, журналист и общественный деятель");
            Console.WriteLine(markTven);

            foreach (string item in PaperStandarts.allFormats.Keys)
            {
                Console.WriteLine(item);
            }

            foreach (Size item in PaperStandarts.allFormats.Values)
            {
                Console.WriteLine($"W: {item.Width}; H: {item.Height}");
            }

            foreach (KeyValuePair<string, Size> item in PaperStandarts.allFormats)
            {
                Console.WriteLine($"Format {item.Key}; Size: W {item.Value.Width}; H {item.Value.Height};");
            }

            Console.WriteLine(PaperStandarts.getSize("A_0"));
            Console.WriteLine(PaperStandarts.getPaperFormat("A_0"));


            string pathToBook = Environment.CurrentDirectory + "\\" + "book_01.txt";
            string[] bookRows = FileReader.ReadTxtFile(pathToBook);
            Console.WriteLine("Колиество строк: " + bookRows.Length);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(bookRows[0]);
            Console.ResetColor();
            Console.Read();*/


            /*Size sizePaper = PaperStandarts.getSize("A_4");
            Console.WriteLine($"Height: {sizePaper.Height}; Width: {sizePaper.Width}. ");*/



            /*List<Page> allPages = 
            StorageReader.getPages(Environment.CurrentDirectory + "\\" + "book_01.txt", PaperStrogeStandarts.getPaperInfo("A_4"));

            Console.WriteLine(allPages[1].Text);*/


            string pathToBook = Environment.CurrentDirectory + "\\" + "book_01.txt";
            string shortDesc = "современный российский писатель-фантаст. Родился в семье учителя и инженера. До четырнадцати лет жил в Киргизии. Потом переехал на Урал";

            Book book_01 = new Book(pathToBook, "Война и мир", Genres.DRAM, Langs.RU, "A_5", "Noname comp*", new DateTime(2019, 05, 05));
            book_01.Authors.Add(new Author("Лев", "Толстой", new DateTime(1980, 01, 01), Gender.MALE, shortDesc));

            Book book_02 = new Book(pathToBook, "Зиний вечер", Genres.LOVE_STORY, Langs.RU, "A_5", "Noname comp*", new DateTime(2019, 05, 05));
            book_02.Authors.Add(new Author("Александр", "Пушкин", new DateTime(1980, 01, 01), Gender.MALE, shortDesc));

            Book book_03 = new Book(pathToBook, "Мертвые души", Genres.DRAM, Langs.RU, "A_5", "Noname comp*", new DateTime(2019, 05, 05));
            book_03.Authors.Add(new Author("Николай", "Гоголь", new DateTime(1980, 01, 01), Gender.MALE, shortDesc));

            Book book_04 = new Book(pathToBook, "Мертвые души", Genres.DRAM, Langs.RU, "A_5", "Noname comp*", new DateTime(2019, 05, 05));
            book_04.Authors.Add(new Author("Кто то", "Неизвестный", new DateTime(1980, 01, 01), Gender.MALE, shortDesc));

            Library library = new Library();
            library.addBook(book_01);
            library.addBook(book_02);
            library.addBook(book_03);
            library.addBook(book_04);


            Console.WriteLine("-------------------------");
            Reader rdr = new Reader("Greg", "Shevchenko", new DateTime(1989, 12, 11), Gender.MALE, "gregshevchenko3@gmail.com", "+380500745280", "38520 Dykanka", ReaderRate.Neutral);
            Console.WriteLine(rdr);
            Console.WriteLine("-------------------------");

            Book book_01_ref = library.getBook(book_01.Authors.First<Author>(), "Тайная жизнь города");
            Console.WriteLine(book_01_ref);

            Console.WriteLine("Нашли книгу: ");
            Console.WriteLine(library.getBook("Война и мир"));
            Console.WriteLine("Её жанр: ");
            Console.WriteLine(library.getBook("Война и мир").Genre);


            Console.WriteLine("Поиск нескольких книг по названию: ");
            Console.WriteLine("Найдено: " + library.getBooks("Мертвые души").Count + "книг");

            ReaderCard card = new ReaderCard(rdr);
            card.AddRecord(book_03);
            Console.WriteLine(card);

            card.DelRecord(book_03);
            Console.WriteLine(card);

            //Library - два метода
            //реализовать book=>Iprinted
            //generic collection
        }
    }
}
