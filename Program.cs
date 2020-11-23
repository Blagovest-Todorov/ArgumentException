using System;

namespace _03.ArgumentExceptionTutorial
{
    class Program
    {

        static void Divide(int a) 
        {
            if (a == 10)
            {
                throw new ArgumentException("Ten is not allowed");
                
            }
            int result = 10 / a;
        }
        static void ReadNumber() 
        {
            int a = int.Parse(Console.ReadLine());
            Divide(a);
        }
        static void Main(string[] args)
        {
            try
            {
                ReadNumber();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
