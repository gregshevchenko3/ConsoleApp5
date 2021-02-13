using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Library
    {
        private SortedDictionary<char, SortedList<Author, List<Book>>> _library;

        //65-90 A-Z
        //97-122 a-z
        //1040-1071
        //1072-1103
        public Library()
        {
            _library = new SortedDictionary<char, SortedList<Author, List<Book>>>(); //пока пусто!!!

            for (int i = 65; i < 91; i++)
            {
                _library.Add((char)i, new SortedList<Author, List<Book>>());
            }
            for (int i = 1040; i < 1072; i++)
            {
                _library.Add((char)i, new SortedList<Author, List<Book>>());
            }
        }

        public void addBook(Book book)
        {
            string surname = book.Authors.First<Author>().Surname.ToUpper(); //получаем фамилию первого автора
            char firstLetter = surname[0]; //первая буква фамилии
            if (_library.ContainsKey(firstLetter))
            {
                //_library[firstLetter] это SortedList<Author, List<Book>>
                if (!_library[firstLetter].ContainsKey(book.Authors.First<Author>()))
                {//если уже есть карточка с автором
                    _library[firstLetter].Add(book.Authors.First<Author>(), new List<Book>());
                }
                //добавляем новую книгу нашему автору
                 _library[firstLetter][book.Authors.First<Author>()].Add(book);
            }
        }
        public List<Book> getAutorWorks(Author author) {
            throw new Exception();
        }
        public Book getBook(Author author, string title)
        {
            char symb = author.Surname.ToUpper()[0];
            if (_library[symb].ContainsKey(author))
            {//если уже есть карточка с автором
                foreach (Book book in _library[symb][author])
                {
                    if (book.Title.ToLower().Equals(title.ToLower()))
                    {
                        return book;
                    }
                }
            }
            return null;
        }
        public List<Book> getBooks(string title)
        {
            List<Book> searchBooks = new List<Book>();
            foreach (var item in _library.Values)
            {
                //Console.WriteLine(item.Values); - коллекция книг одного автора
                foreach (var books in item.Values)
                {
                    //Console.WriteLine(books); //список книг одного автора
                    foreach (var book in books) //получаем доступ к одной книге
                    {
                        if (book.Title.Equals(title)) //если совпадает название книги с названием полученным от читателя
                        {
                            searchBooks.Add(book);
                        }
                    }
                }
            }
            return searchBooks;
        }

        public Book getBook(string title)
        {
            foreach (var item in _library.Values)
            {
                //Console.WriteLine(item.Values); - коллекция книг одного автора
                foreach (var books in item.Values)
                {
                    //Console.WriteLine(books); //список книг одного автора
                    foreach (var book in books) //получаем доступ к одной книге
                    {
                        if (book.Title.Equals(title)) //если совпадает название книги с названием полученным от читателя
                        {
                            return book;
                        }
                    }
                }
            }
            return null;
        }
    }
}
