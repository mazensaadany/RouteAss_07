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

       
    }
}

