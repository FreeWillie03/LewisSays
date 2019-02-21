using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static string Prefix(string input)
        {
            string output = "";
            int num = 0, words = 0;
            foreach(char c in input){
                num++; 
                if(c.equals(' '))
                word++;
            }
            output = $"{num},{word}:{input}"
            return output;
        }
    }
}
