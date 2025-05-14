using System;

class Program
{
    static void Main()
    {
       
        Console.Write("Masukkan tipe customer (platinum/gold): ");
        string customerType = Console.ReadLine().ToLower();

        Console.Write("Masukkan jumlah point reward: ");
        int pointReward = int.Parse(Console.ReadLine());

        Console.Write("Masukkan total belanja: ");
        double totalBelanja = double.Parse(Console.ReadLine());

        
        double diskon = HitungDiskon(customerType, pointReward, totalBelanja);

    
        double totalHarusDibayar = totalBelanja - diskon;

        
        Console.WriteLine($"Diskon yang didapat: {diskon:C}");
        Console.WriteLine($"Total yang harus dibayar: {totalHarusDibayar:C}");
    }

    static double HitungDiskon(string customerType, int pointReward, double totalBelanja)
    {
        double diskon = 0;

        if (customerType == "platinum")
        {
            if (pointReward >= 100 && pointReward <= 300)
            {
                diskon = totalBelanja * 0.50 + 35;
            }
            else if (pointReward >= 301 && pointReward <= 500)
            {
                diskon = totalBelanja * 0.50 + 50;
            }
            else if (pointReward > 500)
            {
                diskon = totalBelanja * 0.50 + 68;
            }
        }
        else if (customerType == "gold")
        {
            if (pointReward >= 100 && pointReward <= 300)
            {
                diskon = totalBelanja * 0.25 + 25;
            }
        }

        return diskon;
    }
}
