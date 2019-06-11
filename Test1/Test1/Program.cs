using System;


namespace Test1
{
    class Program
    {
        public static int Sum(int a,int b)
        {
            int total;
            total = a + b;
            return total;
        }
        static void Main(string[] args)
        {
            
            Console.Write("Enter a number: ");
            int a1 = Convert.ToInt32(Console.ReadLine());
            
            int a = new int();

            
            Console.Write("Enter another number: ");
            int b1 = Convert.ToInt32(Console.ReadLine());
            int b = new int();

            Console.WriteLine("total: " + (a1 + b1));
          
            
        }
    }
}
