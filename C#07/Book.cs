using System.Threading.Channels;

namespace C_07;

internal class Book
{
    #region Q1 field
    private string Password = "secret";
    #endregion

    #region Q2 Field
    internal int copiesInStock = 5;
    #endregion

    #region Q3 field
    public string Title = default!;
    #endregion

    #region Q4 property
    internal Genre Genre { get; set; }
    #endregion
}
