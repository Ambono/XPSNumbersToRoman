namespace NumbersToRomanNumerals
{
    //Algorithm from
    //https://www.c-sharpcorner.com/article/convert-numbers-to-roman-characters-in-c-sharp/

    public class NumberConverter : INumberConverter
    {

        public string ConvertNumber(NumberModel inputModel)
        {
           
            string romanNumeral = string.Empty;

      
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

                while (inputModel.Input != 0)
                {
                    if (inputModel.Input >= numbers[i])
                    {
                        inputModel.Input -= numbers[i];
                        romanNumeral += romanLetters[i];
                    }
                    else
                    {
                        i++;
                    }
                }
                return romanNumeral;
          

        }
    }
}
