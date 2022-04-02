using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    //Interfejsy
    public class Fraction : IEquatable<Fraction>, IComparable<Fraction>
    {
        //prywatne zmienne licznik i mianownik
        private uint numerator;
        private uint denominator;

        public Fraction()
        {

        }

        public Fraction(uint numerator, uint denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public Fraction(Fraction fraction)
        {
            this.numerator = fraction.numerator;
            this.denominator = fraction.denominator;
        }
        public override string ToString()
        {
            return "Ułamek: " + this.numerator + "/" + this.denominator;
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            Fraction result = Fraction.calculatePlusMinusFraction(fraction1, fraction2, "+");
            return result;
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            Fraction result = Fraction.calculatePlusMinusFraction(fraction1, fraction2, "-");
            return result;
        }

        private static Fraction calculatePlusMinusFraction(Fraction fraction1, Fraction fraction2, string character)
        {
            uint nwwDenominator = Fraction.NWW(fraction1.denominator, fraction2.denominator);
            uint firstFractionMultiply = nwwDenominator / fraction2.denominator;
            uint secondFractionMultiply = nwwDenominator / fraction1.denominator;

            Fraction result = new Fraction();
            if(character == "+")
            {
                Console.WriteLine("Dodawanie");
                result.numerator = (fraction1.numerator * secondFractionMultiply) + (fraction2.numerator * firstFractionMultiply);
                result.denominator = (fraction1.denominator * secondFractionMultiply);
            } else if (character == "-")
            {
                Console.WriteLine("Odejmowanie");
                result.numerator = (fraction1.numerator * secondFractionMultiply) - (fraction2.numerator * firstFractionMultiply);
                result.denominator = (fraction1.denominator * secondFractionMultiply);
            }

            uint nwdFraction = Fraction.NWD(result.numerator, result.denominator);

            result.numerator /= nwdFraction;
            result.denominator /= nwdFraction;

            return result;
        }
        public static Fraction operator *(Fraction fraction1, Fraction fraction2)
        {
            Fraction result = new Fraction();
            result.numerator = fraction1.numerator * fraction2.numerator;
            result.denominator = fraction1.denominator * fraction2.denominator;
            return result;
        }

        public static Fraction operator /(Fraction fraction1, Fraction fraction2) 
        { 

            Fraction result = new Fraction();
            result.numerator = fraction1.numerator * fraction2.denominator;
            result.denominator = fraction1.denominator * fraction2.numerator;
            return result;
        }

        public uint Numerator
        {
            get { return (uint)numerator; }
        }

        public uint Denominator
        {
            get { return (uint)denominator; }
        }

        private static uint NWD(uint a, uint b)
        {
            uint pom;
            while (b != 0)
            {
                pom = b;
                b = a % b;
                a = pom;
            }
            return a;
        }

        private static uint NWW(uint a, uint b)
        {
            return a / Fraction.NWD(a, b) * b;
        }

        public bool Equals(Fraction other)
        {
            return denominator == other.Denominator && numerator == other.Numerator;
        }


        public int CompareTo(Fraction other)
        {
            return (int)(this - other).numerator;
        }

        public int ToIntFloor()
        {
            return (int)(Numerator / Denominator);
        }

        public int ToIntCeil()
        {
            return (int)Math.Ceiling((double)Numerator / (double)Denominator);
        }
    }
}
