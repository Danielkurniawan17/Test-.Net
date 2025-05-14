using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string[] firstWords = { "cinema", "host", "aba", "train" };
        string[] secondWords = { "iceman", "shot", "bab", "rain" };

        string result = CheckAnagrams(firstWords, secondWords);
        Console.WriteLine(result); // Output: 1100
    }

    static string CheckAnagrams(string[] firstWords, string[] secondWords)
    {
        if (firstWords.Length != secondWords.Length)
            throw new ArgumentException("Kedua array harus memiliki panjang yang sama.");

        string output = "";

        for (int i = 0; i < firstWords.Length; i++)
        {
            output += AreAnagrams(firstWords[i], secondWords[i]) ? "1" : "0";
        }

        return output;
    }

    static bool AreAnagrams(string word1, string word2)
    {
        return String.Concat(word1.OrderBy(c => c)) == String.Concat(word2.OrderBy(c => c));
    }
}
