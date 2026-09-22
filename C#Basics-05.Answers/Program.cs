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

            PrintBookTitle("Clean Code");
            #region Question 5
            int pages = 400;

            AddBonusPages(pages);

            //Prints 400 because its passing by vakue which means a copy 
            //of pages is altered not the main variable 
            Console.WriteLine(pages);
            #endregion

            #region Question 6
            double[] prices2 = { 25.5, 40.0};
            ApplyDiscount(prices2);

            //prints 20.5 because arrays are a reference type variable
            Console.WriteLine(prices2[0]);
            #endregion

            #region Question 7

            int pages3 = 400;

            AddBonusPagesByRef(ref pages3);

            // it's different from question 5 because here we're passing by ref
            //which means the change ocurrs to the original variable rather than a copy
            //as we're pointing to the same reference in memory
            Console.WriteLine(pages3);
            #endregion

        }



        #region Question 3

        static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }


        #endregion

        #region Question 4

        static void PrintBookTitle(string title)
        {

            Console.WriteLine($"Book Title: {title}");

        }

        #endregion

        #region Question 5

        static int AddBonusPages(int pages)
        {
            return pages + 50;
        }

        #endregion

        #region Question 6

        static void ApplyDiscount(double[] prices2)
        {
            prices2[0] -= 5;
        }

        #endregion

        #region Question 7

        static void AddBonusPagesByRef(ref int pages3)
        {
            pages3 += 50;
        }

        #endregion


    }
}
