using ElectronicLibrary.Models;
using ElectronicLibrary.Repositories;

public class Program
{
	static void Main(string[] args)
	{
		BookRepository bookRepository = new BookRepository();
        UserRepository userRepository = new UserRepository();

        #region

        //Book book1 = new Book()
        //{
        //	Title = "Test1",
        //	PublicationYear = 2019,
        //	Author = "Robin",
        //	Genre = "Trill"
        //};
        //Book book2 = new Book()
        //{
        //	Title = "Test2",
        //	PublicationYear = 2019,
        //	Author = "Robin",
        //	Genre = "Trill"
        //};
        //Book book3 = new Book()
        //{
        //	Title = "Test3",
        //	PublicationYear = 2019,
        //	Author = "Robin",
        //	Genre = "Trill"
        //};

        //User user1 = new User()
        //{
        //	Name = "User1",
        //	Email = "User1@mail.ru"
        //};
        //User user2 = new User()
        //{
        //	Name = "User2",
        //	Email = "User2@mail.ru"
        //};
        //User user3 = new User()
        //{
        //	Name = "User3",
        //	Email = "User3@mail.ru"
        //};

        //bookRepository.Create(book1);
        //bookRepository.Create(book2);
        //bookRepository.Create(book3);

        //userRepository.Create(user1);
        //userRepository.Create(user2);
        //userRepository.Create(user3);

        #endregion

        #region

        //Book book = bookRepository.FindById(1);

        //User user = userRepository.FindById(1);

        //userRepository.CheckOutBook(user, book);

        #endregion

        //1. Получать список книг определенного жанра и вышедших между определенными годами.
        #region

        //List<Book> books = bookRepository.GetBooksByGenreAndYearRange("Trill", 2021, 2022);

        //foreach (Book book in books)
        //{
        //    Console.WriteLine($"{book.Id}, {book.Title}, {book.Author}, {book.PublicationYear}, {book.Genre}");
        //}
        #endregion

        //2. Получать количество книг определенного автора в библиотеке.
        #region
        //int count = bookRepository.GetCountBooksByAuthor("Robin");
        //Console.WriteLine($"Robin: {count}");
        #endregion

        //3. Получать количество книг определенного жанра в библиотеке.
        #region
        //int count = bookRepository.GetCountBooksByGenre("Trill");
        //Console.WriteLine($"Trill: {count}");
        #endregion

        //4. Получать булевый флаг о том, есть ли книга определенного автора и с определенным названием в библиотеке.
        #region
        //bool res = bookRepository.IsBookInLibraryByAuthorAndTitle("Robin", "Test1");
        //Console.WriteLine(res);
        #endregion

        //5. Получать булевый флаг о том, есть ли определенная книга на руках у пользователя.(Неправильно работает.
        //Не понимаю почему. При выборки у User в List<Book> нету списка книг,
        //хотя в бд все привязано и все нормально. Связь много ко многим.). 6 задание по связям. Соотвественно оно также не получилось.
        #region
        //bool res = bookRepository.IsBookBorrowedByUser(2, 3);
        //Console.WriteLine(res);
        #endregion

        //7. Получение последней вышедшей книги.
        #region
        //Book book = bookRepository.GetLatestReleasedBook();
        //Console.WriteLine(book.Title);
        #endregion

        //8. Получение списка всех книг, отсортированного в алфавитном порядке по названию.
        #region
        //List<Book> books = bookRepository.GetAllBooksSortedByTitle();
        //foreach (Book book in books)
        //{
        //    Console.WriteLine(book.Title);
        //}
        #endregion

        //9. Получение списка всех книг, отсортированного в порядке убывания года их выхода.
        #region
        //List<Book> books = bookRepository.GetAllBooksSortedByPublicationYearDescending();
        //foreach (Book book in books)
        //{
        //    Console.WriteLine(book.Title + " " + book.PublicationYear);
        //}
        #endregion
    }
}
