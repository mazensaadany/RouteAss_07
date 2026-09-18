namespace RouteAss_07;

internal class Program
{
    static void Main(string[] args)
    {
        #region 1st answer
        Book book = new Book();
        //Console.WriteLine(book.Password);

        //compile error because Password is
        //private and cannot be accessed
        //outside of the class
        #endregion
        Console.WriteLine("---------------------------------");

        #region 2nd answer
        Console.WriteLine(book.copiesInStock);

        //This will work because copiesInStock is
        //internal and can be accessed within the same assembly
        #endregion
        Console.WriteLine("---------------------------------");

        #region 3rd answer
        book.title = "Route Asp.NET";
        Console.WriteLine(book.title);
        #endregion
        Console.WriteLine("---------------------------------");

        #region 4th answer
        book.BookGenre = Genre.Science;
        Console.WriteLine(book.BookGenre);
        #endregion
        Console.WriteLine("---------------------------------");

        #region 5th answer
        Console.WriteLine((int)Genre.Fiction);
        Console.WriteLine((int)Genre.NonFiction);
        Console.WriteLine((int)Genre.Science);
        #endregion
        Console.WriteLine("---------------------------------");

        #region 6th answer
        int genreNumber = 1;
        Genre genre = (Genre)genreNumber;
        Console.WriteLine(genre);
        #endregion
    }
}

