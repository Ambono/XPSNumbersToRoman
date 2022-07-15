using FluentValidation;

namespace NumbersToRomanNumerals
{
    public class NumberModel
    {
        public int Input { get; set; }
    }

    /// <summary>
    /// Fluent validation for input model
    /// </summary>
    public class NumberValidator : AbstractValidator<NumberModel>
    {
        public NumberValidator()
        {
            RuleFor(number => number.Input).NotNull().WithMessage("Please specify a number");
         
            RuleFor(number => number.Input).NotEqual(0).Must(BeAPositiveNumber).WithMessage("Please a number greater than 0"); ;
        }

        private bool BeAPositiveNumber(int number)
        {
            return number > 0;
        }
    }

   

}
