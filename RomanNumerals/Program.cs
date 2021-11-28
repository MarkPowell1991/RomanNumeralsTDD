

using System.Collections.Generic;

namespace RomanNumeralsTDD
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    // 1    = I
    // 5    = V
    // 10   = X
    // 50   = L
    // 100  = C
    // 500  = D
    // 1000 = M



    
    public class RomanNumerals 
    {

        public static Dictionary<int, string> RomanValueKey()
        {
            Dictionary<int, string> values = new Dictionary<int, string>
        {

                { 4000, "MMMM"},
                { 3000, "MMM"},
                { 2000, "MM"},
                { 1000, "M"},
                { 900, "CM"},
                { 800, "DCCC"},
                { 700, "DCC"},
                { 600, "DC"},
                { 500, "D"},
                { 400, "CD"},
                { 300, "CCC"},
                { 200, "CC"},
                { 100, "C"},
                { 90, "XC"},
                { 80, "LXXX"},
                { 70, "LXX"},
                { 60, "LX"},
                { 50, "L"},
                { 40, "XL"},
                { 30, "XXX"},
                { 20, "XX"},
                { 10, "X"},
                { 5, "V"},
                { 4, "IV"},
                { 1, "I"}
        };
            return values;
        }

        public string RomanNumeral1(int Input)
        {
            return "I";
        }

        public string RomanNumeral2(int input)
        {
            if (input == 1)
            {
                return "I";
            }
            if (input == 2)
            {
                return "II";
            }
            if (input == 3)
            {
                return "III";
            }
            if (input == 4)
            {
                return "IV";
            }
            if (input == 5)
            {
                return "V";
            }
            return input.ToString();
        }


        public string RomanNumeral3(int input)
        {

            string result = string.Empty;
          foreach(KeyValuePair<int,string> item in RomanValueKey() )
            {
                while(input >=  item.Key)
                {
                    result += item.Value;
                    input -= item.Key; 
                }
            }
            return result;

        }





    }

}
