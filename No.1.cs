using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan angka atau huruf: ");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Input tidak boleh kosong.");
            return;
        }

        int mid = (input.Length + 1) / 2; 
        string firstPart = input.Substring(0, mid);
        string secondPart = input.Substring(mid);

        string reversedFirst = ReverseString(firstPart);
        string reversedSecond = ReverseString(secondPart);

        Console.WriteLine("Hasil setelah split dan dibalik:");
        Console.WriteLine(reversedFirst + reversedSecond);
    }

    static string ReverseString(string str)
    {
        char[] array = str.ToCharArray();
        Array.Reverse(array);
        return new string(array);
    }
}
