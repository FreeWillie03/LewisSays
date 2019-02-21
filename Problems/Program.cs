using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            Console.WriteLine(p.Prefix(""));
            Console.WriteLine(p.Prefix("one two three"));
        }

       
        public string Prefix(string input)
        {
            string output = "";
            int num = 0, words = 1;
            if(input == "")
                words--;
            foreach(char c in input){
                num++; 
                if(c == ' ')
                words++;
                
            }
            output = $"{num},{words}:{input}";
            return output;
        }
        
    }
}
