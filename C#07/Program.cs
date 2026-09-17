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

            #region Q3
            book.Title = "Clean Code";
            Console.WriteLine(book.Title);
            //It will combile cuz title is Public.
            #endregion

            #region Q4
            book.Genre = Genre.Science;
            Console.WriteLine(book.Genre);
            #endregion

            #region Q5
            //Cast each enum value to int to print its underlying integer value.
            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);
            #endregion

        }
    }
}
