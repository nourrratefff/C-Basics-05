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

            #region Question 8

            ReplaceArray(ref prices);

            Console.WriteLine(prices.Length);

            #endregion

            #region Sheet 05: Question 1

            if(TryGetPrice("Clean Code", out double price5))
            {
                Console.WriteLine(price5);
            }

            #endregion

            #region Sheet 05: Question 2

            PrintBookInfo("Clean Code", 200);
            #endregion

            #region Sheet 05: Question 3
            PrintBookInfo(pages6: 300, title2: "Clean code");
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


        #region Question 8

        static void ReplaceArray(ref double[] prices4)
        {
            prices4[0] = 10.0; prices4[1] = 12.5; prices4[2] = 15.0; 

        }
        #endregion

        #region Sheet 05: Question 1

        static bool TryGetPrice(string title, out double price5)
        {
            if(title == "Clean Code")
            {
                price5 = 25.0;
                return true;
            }
            else
            {
                price5 = 0;
                return false;
            }
               
        }

        #endregion

        #region Sheet 05: Question 2

        static void PrintBookInfo(string title2, int pages6 = 300)
        {
            Console.WriteLine($"Book Title: {title2}   Pages: {pages6} ");
        }


        #endregion





    }
}
