using System.ComponentModel.DataAnnotations;

namespace Task6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string str = Console.ReadLine();
            string[] strArray = str.Split();
            string max = strArray[0];
            foreach(string s in strArray)
            {
                if (s.Length > max.Length)
                {
                    max = s;
                }
            }
            Console.WriteLine(max);
        }
    }
}