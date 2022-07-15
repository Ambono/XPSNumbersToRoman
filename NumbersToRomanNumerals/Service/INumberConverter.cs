using System.Threading.Tasks;

namespace NumbersToRomanNumerals
{
    public interface INumberConverter
    {
        public  Task<string> ConvertFromRomanToNumber(NumberModel inputModel);
    }
}
