using System.Dynamic;
using System.Runtime.Intrinsics.X86;

namespace Task6_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "А роза {или одуванчик {пушистый} улетел} упала";
            string ss1 = "{";
            string ss2 = "}";
            int begin, end, len ;
            begin = s.IndexOf(ss1) - 1;
            end = s.LastIndexOf(ss2);
            len = end - begin + 1; 
            Console.WriteLine(s.Remove(begin, len));
        }
    }
}