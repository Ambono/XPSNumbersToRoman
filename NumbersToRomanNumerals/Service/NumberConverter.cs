namespace NumbersToRomanNumerals
{
    public class NumberConverter : INumberConverter
    {
      
        public string ConvertNumber(int num)
        {

            string romanResult = string.Empty;
            string[] romanLetters = {
                                "M",
                                "CM",
                                "D",
                                "CD",
                                "C",
                                "XC",
                                "L",
                                "XL",
                                "X",
                                "IX",
                                "V",
                                "IV",
                                "I"
                            };
            int[] numbers = {
                    1000,
                    900,
                    500,
                    400,
                    100,
                    90,
                    50,
                    40,
                    10,
                    9,
                    5,
                    4,
                    1
                };
            int i = 0;
            while (num != 0)
            {
                if (num >= numbers[i])
                {
                    num -= numbers[i];
                    romanResult += romanLetters[i];
                }
                else
                {
                    i++;
                }
            }
            return romanResult;
        }
    }


}
