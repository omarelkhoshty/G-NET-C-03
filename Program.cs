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
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Clean Code";
            string str2 = "Clean Code";
            bool areSameReference = ReferenceEquals(str1, str2);
            Console.WriteLine($"Are str1 and str2 the same reference? {areSameReference}");
        }
    }
    #endregion

}




