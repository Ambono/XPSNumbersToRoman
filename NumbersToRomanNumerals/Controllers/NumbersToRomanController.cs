using Microsoft.AspNetCore.Mvc;
using System;

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
        public IActionResult Get([FromRoute] string number)
        {
            var result = numbersConverter.ConvertNumber(Convert.ToInt32(number));

            return Ok(result);
        }
    }
}