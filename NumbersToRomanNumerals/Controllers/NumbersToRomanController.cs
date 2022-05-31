using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace NumbersToRomanNumerals.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumbersToRomanController : ControllerBase
    {
        private readonly INumberConverter numbersConverter;

        public NumbersToRomanController(INumberConverter numbersConverter)
        {
            this.numbersConverter = numbersConverter;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        [HttpGet("ConvertNumber/{number}")]
        public IActionResult Get([FromRoute] int number)
        {
            var inputModel = new NumberModel() { Input = number };
            NumberValidator validator = new NumberValidator();

            ValidationResult results = validator.Validate(inputModel);

            if (!results.IsValid)
            {

                return BadRequest();

            }

            var result = numbersConverter.ConvertNumber(inputModel);

            return Ok(result);
        }
    }
}