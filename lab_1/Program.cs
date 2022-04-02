using System;

namespace lab_1;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Start programu");
        Fraction fraction0 = new Fraction();
        Fraction fraction1 = new Fraction(5,10);
        Fraction fraction3 = new Fraction(5,20);
        Fraction fraction2 = new Fraction(fraction1);
        Console.WriteLine(fraction0);
        Console.WriteLine(fraction2);
        Console.WriteLine(fraction3);
        Fraction overloadPlus = fraction1 + fraction3;
        Console.WriteLine(overloadPlus);
        Fraction overloadMinus = fraction1 - fraction3;
        Console.WriteLine(overloadMinus);
        Fraction overloadDivide = fraction1 / fraction3;
        Console.WriteLine(overloadDivide);
        Fraction overloadMultiply = fraction1 * fraction3;
        Console.WriteLine(overloadMultiply);

        Random rand = new Random();
        Fraction[] fractionsToSort = new Fraction[10];

        for (int i = 0; i < 10; i++)
        {
            fractionsToSort[i] = new Fraction(Convert.ToUInt32(rand.Next(1, 100)), Convert.ToUInt32(rand.Next(1, 100)));
        }
        Console.WriteLine("Ułamki do posortowania");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(fractionsToSort[i]);
        }
    }
}
