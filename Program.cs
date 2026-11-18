using System.Drawing;
using System.Text;

namespace GNET_C_03
{

    #region Question 1
    //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change.
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string title = "clean code";
    //        string upperTitle = title.ToUpper();
    //        Console.WriteLine($"Original: {title}");
    //        Console.WriteLine($"Uppercase: {upperTitle}");
    //    }
    //}

    #endregion

    #region Question 2 
    //Declare two separate string variables, both set to the literal "Clean Code". Use ReferenceEquals() to check if they point to the same object in memory.
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string str1 = "Clean Code";
    //        string str2 = "Clean Code";
    //        bool areSameReference = ReferenceEquals(str1, str2);
    //        Console.WriteLine($"Are str1 and str2 the same reference? {areSameReference}");
    //    }
    //}
    #endregion

    #region Question 3

    //Create a StringBuilder, Append() the text "Book List", then Append() " - Updated" onto the same object. Print the final result.

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        StringBuilder sb = new StringBuilder();
    //        sb.Append("Book List");
    //        sb.Append(" - Updated");
    //        Console.WriteLine(sb.ToString());
    //    }
    //}

    #endregion

    #region Question 4
    //Using the StringBuilder from the question above, use Replace() to change "Book List" into "Library". Print the result.

    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Book List");
            sb.Append(" - Updated");
            sb.Replace("Book List", "Library");
            Console.WriteLine(sb.ToString());
        }
    }
    #endregion
}






