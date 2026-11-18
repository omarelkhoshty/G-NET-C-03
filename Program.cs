using System.Drawing;
using System.Runtime.Intrinsics.X86;
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

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        StringBuilder sb = new StringBuilder();
    //        sb.Append("Book List");
    //        sb.Append(" - Updated");
    //        sb.Replace("Book List", "Library");
    //        Console.WriteLine(sb.ToString());
    //    }
    //}
    #endregion

    #region Question 5
    //Given string title = "Clean Code"; and int pages = 464;, build the sentence "Book: Clean Code, Pages: 464" using the + operator. 
    //internal class program
    //{
    //    static void Main(string[] args)
    //    {
    //        string title = "Clean Code";
    //        int pages = 464;
    //        string result = "Book: " + title + ", Pages: " + pages;
    //        Console.WriteLine(result);
    //    }
    //}
    #endregion

    #region Question 6 
    //Build the same sentence as above, but using string interpolation ($"...").
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        string title = "Clean Code";
    //        int pages = 464;
    //        string result = $"Book: {title}, Pages: {pages}";
    //        Console.WriteLine(result);
    //    }
    //}
    #endregion

    #region Question 7
    //Build the same sentence again, but using string.Format().
    //internal class program
    //{
    //    static void Main(string[] args)
    //    {
    //        string title = "Clean Code";
    //        int pages = 464;
    //        string result = string.Format("Book: {0}, Pages: {1}", title, pages);
    //        Console.WriteLine(result);
    //    }
    //}
    #endregion

    #region Question 8 

    //Given int pages = 464;, write an if / else statement that prints "Long Book" if pages is greater than 300, otherwise prints "Short Book"

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        int pages = 464;
    //        if (pages > 300)
    //        {
    //            Console.WriteLine("Long Book");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Short Book");
    //        }
    //    }
    //}
    #endregion

    #region Question 9
    //Given int pages = 464; and bool isAvailable = true;, print "You can borrow this book" only if pages is greater than 300 and isAvailable is true. Use the && operator. 
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = 464;
            bool isAvailable = true;
            if (pages > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }
        }
    }
    #endregion
}







