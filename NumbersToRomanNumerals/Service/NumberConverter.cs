

using System.Threading.Tasks;

namespace NumbersToRomanNumerals
{
   
    public class NumberConverter : INumberConverter
    {

        public async Task<string> ConvertFromRomanToNumber(NumberModel inputModel)
        {
           
            string romanNumeral = string.Empty;
                  
                string[] romanLetters = {RomanLetters.THOUSAND,RomanLetters.NINE_HUNDRED,RomanLetters.FIVE_HUNDRED,RomanLetters.FOUR_HUNDRED,RomanLetters.HUNDRED,
                 RomanLetters.NINETY,RomanLetters.FIFETY,RomanLetters.FOURTY,RomanLetters.TEN,RomanLetters.NINE,RomanLetters.FIVE,RomanLetters.FOUR,RomanLetters.ONE};

                int[] numbers = {Numbers.THOUSAND,Numbers.NINE_HUNDRED,Numbers.FIVE_HUNDRED,Numbers.FOUR_HUNDRED,Numbers.HUNDRED,Numbers.NINETY,Numbers.FIFETY,
                Numbers.FOURTY,Numbers.TEN,Numbers.NINE,Numbers.FIVE,Numbers.FOUR,Numbers.ONE};

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
