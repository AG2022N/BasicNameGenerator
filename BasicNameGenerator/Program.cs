using System;
using System.IO;
using System.Text;
using System.Threading;

namespace BasicNameGenerator
{
    internal class Program
    {
        public static string    maleOutput                        = @"Output\\OutputMale.txt";
        public static string    femaleOutput                      = @"Output\\OutputFemale.txt";
        static void Main()
        {
            int UserInput = 0;
            while (UserInput != 3)
            {
                int maxGen, Counter = 0;
                Console.Clear();

                Console.SetCursorPosition(0, 1);
                Console.WriteLine("     Type '1' to generate male names");
                Console.WriteLine("     Type '2' to generate female names");
                Console.WriteLine("     type '3' to exit");
                Console.SetCursorPosition(5, 27);
                Console.Write("Choose: ");
                UserInput = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (UserInput != 3)
                {
                    Console.SetCursorPosition(5, 1);
                    Console.Write("Type the number of names to generate: ");
                    maxGen = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    Console.SetCursorPosition(0, 1);
                    while (UserInput == 1 && Counter != maxGen)
                    {
                        Thread.Sleep(1);
                        string randomName = NameGenerator.GenerateNameMale();
                        StreamWriter sw = new StreamWriter(maleOutput, true, Encoding.ASCII);
                        sw.WriteLine(randomName);
                        sw.Close();
                        Console.WriteLine("     {0}", randomName);
                        Counter++;
                    }
                    while (UserInput == 2 && Counter != maxGen)
                    {
                        Thread.Sleep(1);
                        string randomName = NameGenerator.GenerateNameFemale();
                        StreamWriter sw = new StreamWriter(femaleOutput, true, Encoding.ASCII);
                        sw.WriteLine(randomName);
                        sw.Close();
                        Console.WriteLine("     {0}", randomName);
                        Counter++;
                    }
                    Console.ReadKey();
                }              
            }
        }
    }
}