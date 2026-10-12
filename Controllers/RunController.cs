using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Speedrunner_leaderboard_API_Brandon_Langehennig.DTOs;
using Speedrunner_leaderboard_API_Brandon_Langehennig.Models;
using Speedrunner_leaderboard_API_Brandon_Langehennig.Services;

namespace Speedrunner_leaderboard_API_Brandon_Langehennig.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RunController : ControllerBase
    {
        private readonly IRunServices _runs;

        public RunController(IRunServices runs)
        {
            _runs = runs;
        }


        [HttpGet]

        public ActionResult<List<RunResponseDto>> GetAll()
        {
            
            return Ok(_runs.GetAll());
        }


        [HttpGet("{id}")]

        public ActionResult<RunResponseDto> GetById(int id)
        {
            RunResponseDto? run = _runs.GetById(id);

            if (run == null)
            {
                return NotFound();
            }

            return Ok(run);
        }

       [HttpGet("category/{category}")]

        public ActionResult<RunResponseDto> GetByCategory(string category)
        {
            RunResponseDto? run = _runs.GetByCategory(category);

            if (run == null)
            {
                return NotFound();
            }

            return Ok(run);
        }

        [HttpPost]

        public ActionResult<RunResponseDto> Add([FromBody] CreateRunDto newRun)
        {
            RunResponseDto? run = _runs.Add(newRun);

            if (run == null)
            {
                return BadRequest("Run with this ID already exists.");
            }

            return CreatedAtAction(nameof(GetById), new { id = run.Id }, run);
        }

        [HttpPut("{id}")]

        public ActionResult Update(int id, Run exsistingRun)
        {
            bool updated = _runs.Update(id, exsistingRun);

            if (!updated)
            {
                return NotFound();
            }

            return NoContent();
        }

        [HttpDelete("{id}")]

        public ActionResult Delete(int id)
        {
            _runs.Delete(id);
            return NoContent();
        }



    }
}