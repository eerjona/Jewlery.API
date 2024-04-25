using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Jewlery.API.Dto;

namespace Jewlery.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JewleryController : ControllerBase
    {

        [HttpGet("All")]
        public IActionResult GetJewlery()
        {
            //List of students
            var allJewlery = new List<Jewlery.API.Models.Jewlery>()
            {
                new Jewlery.API.Models.Jewlery()
                {
                    Id = 1,
                    Type = "First Ring ",
                    Collection = DateTime.Now.AddYears(-20)
                },
                new Jewlery.API.Models.Jewlery()
                {
                    Id = 2,
                    Type = "Second Ring",
                    Collection = DateTime.Now.AddYears(-20)
                },
            };

            return Ok(allJewlery);
        }

        [HttpGet("GetById/{id}")]
        public IActionResult GetJewleryById(int id)
        {
            var newJewlery = new Models.Jewlery()
            {
                Id = 1,
                Type = "First Ring",
                Collection = DateTime.Now.AddYears(-20)
            };

            return Ok(newJewlery);
        }


        [HttpPost]
        public IActionResult AddNewJewlery([FromBody] PostJewleryDto payload)
        {
            return Ok(payload);
        }


        [HttpPut("{id}")]
        public IActionResult UpdateJewlery([FromBody] PutJewleryDto payload, int id)
        {
            return Ok(payload);
        }


        [HttpDelete("DeleteById/{id}")]
        public IActionResult DeleteJewlery(int id)
        {
            return Ok();
        }

    }
}
