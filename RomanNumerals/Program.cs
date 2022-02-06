using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumerals
{
    class Program
    {
        static void Main(string[] args)
        {
            string romanNumeral;
            string number;
            while (true)
            {
                Program program = new Program();

                Console.WriteLine("Please put a Roman numeral to see its equivelent.");
                romanNumeral = Console.ReadLine();

                if(program.findRomanNumeral(romanNumeral) > 0)
                {
                    Console.WriteLine("The Number you choose is: " +  program.findRomanNumeral(romanNumeral));
                }
                else
                {
                    Console.WriteLine("The value you put is not expected.");
                }

                Console.WriteLine("Please put a number to see its Roman equivelent.");
                number = Console.ReadLine();
                Console.WriteLine(program.findNumericalEquivelent(number));


            }
            
        }

        int findRomanNumeral(string romanNumeral)
        {
            bool[]  isNumericValueSet = { false, false, false, false};
            int result = 0;
            PartialRomanToNumber(ref result, ref romanNumeral, "VIII", 8, ref isNumericValueSet[0]);
            PartialRomanToNumber(ref result, ref romanNumeral, "III", 3, ref isNumericValueSet[0]);
            PartialRomanToNumber(ref result, ref romanNumeral, "VII", 7, ref isNumericValueSet[0]);
            PartialRomanToNumber(ref result, ref romanNumeral, "II", 2, ref isNumericValueSet[0]);
            PartialRomanToNumber(ref result, ref romanNumeral, "IV", 4, ref isNumericValueSet[0]);
            PartialRomanToNumber(ref result, ref romanNumeral, "VI", 6, ref isNumericValueSet[0]);
            PartialRomanToNumber(ref result, ref romanNumeral, "IX", 9, ref isNumericValueSet[0]);
            PartialRomanToNumber(ref result, ref romanNumeral, "I", 1, ref isNumericValueSet[0]);
            PartialRomanToNumber(ref result, ref romanNumeral, "V", 5, ref isNumericValueSet[0]);
            PartialRomanToNumber(ref result, ref romanNumeral, "LXXX", 80, ref isNumericValueSet[1]);
            PartialRomanToNumber(ref result, ref romanNumeral, "XXX", 30, ref isNumericValueSet[1]);
            PartialRomanToNumber(ref result, ref romanNumeral, "LXX", 70, ref isNumericValueSet[1]);
            PartialRomanToNumber(ref result, ref romanNumeral, "XX", 20, ref isNumericValueSet[1]);
            PartialRomanToNumber(ref result, ref romanNumeral, "XL", 40, ref isNumericValueSet[1]);
            PartialRomanToNumber(ref result, ref romanNumeral, "LX", 60, ref isNumericValueSet[1]);
            PartialRomanToNumber(ref result, ref romanNumeral, "XC", 90, ref isNumericValueSet[1]);
            PartialRomanToNumber(ref result, ref romanNumeral, "X", 10, ref isNumericValueSet[1]);
            PartialRomanToNumber(ref result, ref romanNumeral, "L", 50, ref isNumericValueSet[1]);
            PartialRomanToNumber(ref result, ref romanNumeral, "DCCC", 800, ref isNumericValueSet[2]);
            PartialRomanToNumber(ref result, ref romanNumeral, "CCC", 300, ref isNumericValueSet[2]);
            PartialRomanToNumber(ref result, ref romanNumeral, "DCC", 700, ref isNumericValueSet[2]);
            PartialRomanToNumber(ref result, ref romanNumeral, "CC", 200, ref isNumericValueSet[2]);
            PartialRomanToNumber(ref result, ref romanNumeral, "CD", 400, ref isNumericValueSet[2]);
            PartialRomanToNumber(ref result, ref romanNumeral, "DC", 600, ref isNumericValueSet[2]);
            PartialRomanToNumber(ref result, ref romanNumeral, "CM", 900, ref isNumericValueSet[2]);
            PartialRomanToNumber(ref result, ref romanNumeral, "C", 100, ref isNumericValueSet[2]);
            PartialRomanToNumber(ref result, ref romanNumeral, "D", 500, ref isNumericValueSet[2]);
            PartialRomanToNumber(ref result, ref romanNumeral, "MMM", 3000, ref isNumericValueSet[3]);
            PartialRomanToNumber(ref result, ref romanNumeral, "MM", 2000, ref isNumericValueSet[3]);
            PartialRomanToNumber(ref result, ref romanNumeral, "M", 1000, ref isNumericValueSet[3]);

            if(romanNumeral.Length > 0)
            {
                result = 0;
            }
            return result;
        }

        void PartialRomanToNumber(ref int result, ref string romanNumeral, string RomanNumeralPart, int NumeralEquivalant, ref bool isSet)
        {
            if (!isSet)
            {
                if (romanNumeral.EndsWith(RomanNumeralPart))
                {
                    romanNumeral = romanNumeral.Remove(romanNumeral.Length - RomanNumeralPart.Length);
                    result += NumeralEquivalant;
                    isSet = true;
                }
            }
        }

        string findNumericalEquivelent(string number)
        {
            bool[] isNumericValueSet = { false, false, false, false };
            string result = "";
            PartialRomanToNumber(ref number, ref result, "VIII", "8", ref isNumericValueSet[0]);
            PartialRomanToNumber(ref number, ref result, "III", "3", ref isNumericValueSet[0]);
            PartialRomanToNumber(ref number, ref result, "VII", "7", ref isNumericValueSet[0]);
            PartialRomanToNumber(ref number, ref result, "II", "2", ref isNumericValueSet[0]);
            PartialRomanToNumber(ref number, ref result, "IV", "4", ref isNumericValueSet[0]);
            PartialRomanToNumber(ref number, ref result, "VI", "6", ref isNumericValueSet[0]);
            PartialRomanToNumber(ref number, ref result, "IX", "9", ref isNumericValueSet[0]);
            PartialRomanToNumber(ref number, ref result, "I", "1", ref isNumericValueSet[0]);
            PartialRomanToNumber(ref number, ref result, "V", "5", ref isNumericValueSet[0]);
            PartialRomanToNumber(ref number, ref result, "", "0", ref isNumericValueSet[0]);
            PartialRomanToNumber(ref number, ref result, "LXXX", "8", ref isNumericValueSet[1]);
            PartialRomanToNumber(ref number, ref result, "XXX", "3", ref isNumericValueSet[1]);
            PartialRomanToNumber(ref number, ref result, "LXX", "7", ref isNumericValueSet[1]);
            PartialRomanToNumber(ref number, ref result, "XX", "2", ref isNumericValueSet[1]);
            PartialRomanToNumber(ref number, ref result, "XL", "4", ref isNumericValueSet[1]);
            PartialRomanToNumber(ref number, ref result, "LX", "6", ref isNumericValueSet[1]);
            PartialRomanToNumber(ref number, ref result, "XC", "9", ref isNumericValueSet[1]);
            PartialRomanToNumber(ref number, ref result, "X", "1", ref isNumericValueSet[1]);
            PartialRomanToNumber(ref number, ref result, "L", "5", ref isNumericValueSet[1]);
            PartialRomanToNumber(ref number, ref result, "", "0", ref isNumericValueSet[1]);
            PartialRomanToNumber(ref number, ref result, "DCCC", "8", ref isNumericValueSet[2]);
            PartialRomanToNumber(ref number, ref result, "CCC", "3", ref isNumericValueSet[2]);
            PartialRomanToNumber(ref number, ref result, "DCC", "7", ref isNumericValueSet[2]);
            PartialRomanToNumber(ref number, ref result, "CC", "2", ref isNumericValueSet[2]);
            PartialRomanToNumber(ref number, ref result, "CD", "4", ref isNumericValueSet[2]);
            PartialRomanToNumber(ref number, ref result, "DC", "6", ref isNumericValueSet[2]);
            PartialRomanToNumber(ref number, ref result, "CM", "9", ref isNumericValueSet[2]);
            PartialRomanToNumber(ref number, ref result, "C", "1", ref isNumericValueSet[2]);
            PartialRomanToNumber(ref number, ref result, "D", "5", ref isNumericValueSet[2]);
            PartialRomanToNumber(ref number, ref result, "", "0", ref isNumericValueSet[2]);
            PartialRomanToNumber(ref number, ref result, "MMM", "3", ref isNumericValueSet[3]);
            PartialRomanToNumber(ref number, ref result, "MM", "2", ref isNumericValueSet[3]);
            PartialRomanToNumber(ref number, ref result, "M", "1", ref isNumericValueSet[3]);

            if (number.Length > 0)
            {
                result = "";
            }
            return result;
        }

        void PartialRomanToNumber(ref string number, ref string result, string RomanNumeralEquivalant, string NumeralPart, ref bool isSet)
        {
            if (!isSet)
            {

                if (number.EndsWith(NumeralPart))
                {
                    number = number.Remove(number.Length - 1);
                    result = RomanNumeralEquivalant + result;
                    isSet = true;
                }

            }
        }
    }
}
