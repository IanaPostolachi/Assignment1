using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment.Data;
using Assignment.Model;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultsController : ControllerBase
    {
        private readonly IFileContext FileContext;

        public AdultsController(IFileContext fileContext)
        {
            this.FileContext = fileContext;
        }
        
        [HttpGet]
        public async Task<ActionResult<IList<Adult>>> GetAdultsAsync([FromQuery] int? Id, [FromQuery] string? firstName)
        {
            try
            {
                IList<Adult> adults = await FileContext.GetAdultsAsync();
                if (Id != null)
                { 
                    adults = adults.Where(adult => adult.Id == Id).ToList();
                }

                if (firstName != null)
                {
                    adults = adults.Where(adult => adult.FirstName == firstName).ToList();
                }
                return Ok(adults);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpPost]
        public async Task<ActionResult<Adult>> PostTodo([FromBody]Adult adult)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Adult addedAdult = await FileContext.AddAdultsAsync(adult);
                return Created($"/{addedAdult.Id}", addedAdult);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
        
        [HttpDelete]
        [Route("{Id:int}")]
        public async Task<ActionResult> RemoveTodo([FromRoute] int Id)
        {
            try
            {
                await FileContext.RevomeAdultsAsync(Id);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}