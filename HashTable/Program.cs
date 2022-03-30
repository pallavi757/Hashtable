
using System;
namespace HashTable
{
    class Program
    {
        public static void count_freq(string msg, MyMapNode<string, int> storedDictionary)
        {
            string[] words = msg.Split(' ');
            foreach (string word in words)
            {
                if (storedDictionary.Exists(word))//Check if word already exist in dictionary 
                {
                    storedDictionary.Add(word, storedDictionary.Get(word) +1);
                }
                else
                {
                    storedDictionary.Add(word,1);
                }
            }
            storedDictionary.Display();

        }
        public static void Main(string[] args)
        {
            Console.WriteLine(" Hash table program");
           // MyMapNode<string, int> storedDictionary = new MyMapNode<string, int>(5);
            //count_freq("To be or not to be", storedDictionary);
            MyMapNode<string, int> newstoredDictionary = new MyMapNode<string, int>(10);
            count_freq("Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations", newstoredDictionary);
        }
    }
}