using System.IO;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"C:\Users\ADILET\source\repos\ConsoleApp21\ConsoleApp21\input.txt");
            StreamWriter sw = new StreamWriter(@"C:\Users\ADILET\source\repos\ConsoleApp21\ConsoleApp21\output.txt");
            int count = int.Parse(sr.ReadToEnd()) + 1;
            sw.WriteLine(count);
            sw.Close();
        }
    }
}
