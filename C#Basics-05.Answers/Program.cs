namespace C_Basics_05.Answers
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Sheet 04: Question 1 

            double[] prices = { 25.5, 40.0, 33.75 };

            #endregion

            #region Question 2

            int[,] shelfCopies = { 
                {3, 5 },
                {1, 4 } };

            Console.WriteLine(shelfCopies[1, 0]);



            #endregion

            PrintWelcomeMessage();

        }


        #region Question 3

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }


        #endregion
    }
}
