namespace Task6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение");
            string str = Console.ReadLine();
            string[] strArray = str.ToLower().Split();
            string str2 = "";
            string str1 = "";

            foreach (string s in strArray)
            {
                str1 = str1 + s;
            }
            foreach (char c in str1)
            {
                str2 = c + str2;
            }

            if (str2 == str1) 
            { 
                Console.WriteLine("Это палиндром");
                return;
            }
            Console.WriteLine("Палиндром не получился");
        }
    }
}