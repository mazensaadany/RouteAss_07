namespace RouteAss_07
{
    internal class Book
    {
        private string password="secret";

        internal int copiesInStock = 5;

        public string title;

        public Genre BookGenre{ get; set; }
    }
}
