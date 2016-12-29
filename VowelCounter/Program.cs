using System;

namespace VowelCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Enter a word and I will count the number of vowels.");
            string strWord = Console.ReadLine().ToUpper();
            string[] vowels = { "A", "E", "I", "O", "U" };
            int count = 0;

            foreach (string t in vowels) 
                {
                
                            if(strWord.Contains(t))
                                {
                                    count += 1;
                    //count
                                }
                    
                }
            
            Console.WriteLine("There are " + count.ToString() + " vowels in your word!");
            Console.ReadKey();
        }
    }
}
