namespace GNET_C_03
{
    //Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change. 
    #region Question 1
    internal class Program
    {
        static void Main(string[] args)
        {
            string title = "clean code";
            string upperTitle = title.ToUpper();
            Console.WriteLine($"Original: {title}");
            Console.WriteLine($"Uppercase: {upperTitle}");
        }
    }

    #endregion
}



//Declare string title = "clean code";. Call title.ToUpper() and store it in a new variable upperTitle. Print both title and upperTitle to show that title did not change. 