namespace C_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Book book = new();
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

            #region Q6
            int genreNumber = 1;
            Genre genre = (Genre)genreNumber;
            Console.WriteLine(genre);
            // index 1 -> fiction
            #endregion

            #region Q7
            Genre genre07 = Genre.Fiction;
            Console.WriteLine(genre07.ToString());
            #endregion

            #region Q8
            string genreText = "Science";
            Genre genre08 =(Genre) Enum.Parse(typeof(Genre) ,genreText );
            Console.WriteLine(genre08);
            #endregion
        }
    }
}
