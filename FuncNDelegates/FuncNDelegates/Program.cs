using System;

namespace FuncNDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Action printText = new Action(MethodCollections.PrintText);   
            Action<string> print = new Action<string>(MethodCollections.Print);   
            Action<int, int> printNumber = new Action<int, int>(MethodCollections.PrintNumbers);   
   
            Func<int, int,int> add1 = new Func<int, int, int>(MethodCollections.Addition);   
            Func<int, int, string> add2 = new Func<int, int, string>(MethodCollections.DisplayAddition);   
            Func<string, string, string> completeName = new Func<string, string, string>(MethodCollections.SHowCompleteName);   
            Func<int> random = new Func<int>(MethodCollections.ShowNumber);   
   
            Console.WriteLine("\n***************** Action<> Delegate Methods ***************\n");   
            printText();    //Parameter: 0 , Returns: nothing   
            print("Srinivas Bheemareddy    ");  //Parameter: 1 , Returns: nothing   
            printNumber(5, 20); //Parameter: 2 , Returns: nothing   
            Console.WriteLine();   
            Console.WriteLine("**************** Func<> Delegate Methods *****************\n");   
            int addition = add1(2, 5);  //Parameter: 2 , Returns: int   
            string addition2 = add2(5, 8);  //Parameter: 2 , Returns: string   
            string name = completeName("Srinivas", "Bheemareddy");    //Parameter:2 , Returns: string   
            int randomNumbers = random();   ////Parameter: 0 , Returns: int   
   
            Console.WriteLine("Addition: {0}",addition);   
            Console.WriteLine(addition2);   
            Console.WriteLine(name);   
            Console.WriteLine("Random Number is: {0}",randomNumbers);   
   
            Console.ReadLine();  

        }
    }


    class MethodCollections
    {

        //Methods that takes parameters but returns nothing:   

        public static void PrintText()
        {
            Console.WriteLine("Text Printed with the help of Action");
        }

        public static void PrintNumbers(int start, int target)
        {
            for (int i = start; i <= target; i++)
            {
                Console.Write(" {0}", i);
            }
            Console.WriteLine();
        }

        public static void Print(string message)
        {
            Console.WriteLine(message);
        }

        //Methods that takes parameters and returns a value:   

        public static int Addition(int a, int b)
        {
            return a + b;
        }

        public static string DisplayAddition(int a, int b)
        {
            return string.Format("Addition of {0} and {1} is {2}", a, b, a + b);
        }

        public static string SHowCompleteName(string firstName, string lastName)
        {
            return string.Format("Your Name is {0} {1}", firstName, lastName);
        }

        public static int ShowNumber()
        {
            Random r = new Random();
            return r.Next();
        }

    }

}
