using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Rüya manavına hoş geldiniz!");
        Console.Write("Hangi meyveyi satın almak istiyorsunuz? ");
        string meyve = Console.ReadLine().ToLower(); // Büyük/küçük harf duyarlılığını ortadan kaldırmak için ToLower kullanıyoruz.

        switch (meyve)
        {
            case "elma":
                Console.WriteLine("Elma: 2 TL");
                break;
            case "armut":
                Console.WriteLine("Armut: 3 TL");
                break;
            case "çilek":
                Console.WriteLine("Çilek: 2 TL");
                break;
            case "muz":
                Console.WriteLine("Muz: 3 TL");
                break;
            default:
                Console.WriteLine($"{meyve}: 4 TL");
                break;
        }
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Rüya manavına hoş geldiniz!");
        Console.Write("Hangi meyveyi satın almak istiyorsunuz? ");
        string meyve = Console.ReadLine().ToLower(); // Büyük/küçük harf duyarlılığını ortadan kaldırmak için ToLower kullanıyoruz.

        if (meyve == "elma")
        {
            Console.WriteLine("Elma: 2 TL");
        }
        else if (meyve == "armut")
        {
            Console.WriteLine("Armut: 3 TL");
        }
        else if (meyve == "çilek")
        {
            Console.WriteLine("Çilek: 2 TL");
        }
        else if (meyve == "muz")
        {
            Console.WriteLine("Muz: 3 TL");
        }
        else
        {
            Console.WriteLine($"{meyve}: 4 TL");
        }
    }
}fadf
