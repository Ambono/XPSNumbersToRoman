using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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
        public async Task<IActionResult> Get([FromRoute] int number)
        {
            var inputModel = new NumberModel() { Input = number };
            NumberValidator validator = new NumberValidator();

            ValidationResult results = validator.Validate(inputModel);

            if (!results.IsValid)
            {

                return BadRequest();

            }

            var result = await numbersConverter.ConvertFromRomanToNumber(inputModel);

            return Ok(result);
        }
    }
}