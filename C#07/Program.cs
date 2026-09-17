namespace C_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Book book = new Book();
            //Console.WriteLine(book.Password);
            ////It won't compile cuz Password is private, so it cannot be accessed from outside the Book class.
            #endregion

            #region Q2
            Console.WriteLine(book.copiesInStock);
            //It will combile cuz copiesInStock is internal, so so it can be accessed from outside the Book class(but in the same project).
            #endregion

        }
    }
}
