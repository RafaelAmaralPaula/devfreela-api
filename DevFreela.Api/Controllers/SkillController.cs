
using DevFreela.Application.DTOS.SkillDataTransferObject;
using DevFreela.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Api.Controllers
{
    [ApiController]
    [Route("/api/skills")]
    public class SkillController : ControllerBase
    {
        
        private readonly ISkillService _serivce;

        public SkillController(ISkillService serivce)
        {
            _serivce = serivce;
        }

        [HttpGet]
        public IActionResult FindAll()
        {
            var skills = _serivce.FindAll();

            return Ok(skills);
        }

        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            var skill = _serivce.FindById(id);

            if(skill == null)
            {
                return NotFound();
            }

            return Ok(skill);

        }

        [HttpPost]
        public IActionResult Save([FromBody] SkillDTO skillDTO)
        {
            var result = _serivce.Save(skillDTO);
            return Created($"api/skills/{result.Id}" , result);
            
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] SkillDTO skillDTO)
        {
            _serivce.Update(id, skillDTO);
            return NoContent();

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _serivce.Delete(id);
            return NoContent();
        }
    }
}
