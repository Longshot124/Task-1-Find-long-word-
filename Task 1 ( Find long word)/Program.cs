using System;

namespace Task_1___Find_long_word_
{
    class Program
    {
        static void Main(string[] args)
        {
            //var BigName ;
            //Console.WriteLine(BigName);

            //string[] names = { "Hesen", "Eli", "Nerbala", "Fazil" };
            //foreach (string name in names)
            //{
            //    Console.WriteLine(names.GetLongLength(BigName).ToString());
            //}
            //Console.WriteLine("");

            string[] array = { "Hesen", "Eli", "Nerbala", "Aqil", "Elshen", "Fazil" };

            int maxLen = 0;
            int indexMax = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i].Length > maxLen)
                {
                    maxLen = array[i].Length;
                    indexMax = i;
                }
                //else
                //{
                //    Console.WriteLine("Adlar beraberdir");
                //}

            }
            Console.WriteLine("Long Name is " + array[indexMax]);

            
           

        }
    }
}
