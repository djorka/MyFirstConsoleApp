using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string sName = "Andrew Schirmer";
            int iCount;

            for (iCount = 0; iCount < 3; iCount++)
            {
                Console.WriteLine(sName + " loves Fried SPAM!");
            }

            Console.ReadLine();

        }
    }
}
