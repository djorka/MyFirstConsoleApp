using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string sName = "Andrew";
            string sDog = "Roo";
            int iCount;

            for (iCount = 0; iCount < 3; iCount++)
            {
                Console.WriteLine(sName + " " + sDog + " loves Fried SPAM!");
            }

            Console.ReadLine();

        }
    }
}
