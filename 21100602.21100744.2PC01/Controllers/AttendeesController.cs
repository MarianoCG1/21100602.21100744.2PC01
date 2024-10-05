using _21100602._21100744._2PC01.Entities;
using _21100602._21100744._2PC01.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _21100602._21100744._2PC01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendeesController : ControllerBase
    {
        private readonly IAttendeesRepository _attendeesRepository;

        public AttendeesController(IAttendeesRepository attendeesRepository)
        {
            _attendeesRepository = attendeesRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var attendees = await _attendeesRepository.GetAll();
            return Ok(attendees);
        }

        [HttpPost]

        public async Task<IActionResult> Insert([FromBody]Attendees attendees)
        {
            int attendeesID = await _attendeesRepository.Insert(attendees);
            return Ok(attendeesID);
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            var result = await _attendeesRepository.Delete(id);
            if (!result) return NotFound();
            return Ok(result);
        }
        

        }
    }

