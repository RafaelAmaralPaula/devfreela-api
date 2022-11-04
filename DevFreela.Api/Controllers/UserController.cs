using DevFreela.Application.DTOS.SkillDataTransferObject;
using DevFreela.Application.DTOS.UserDataTransferObject;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {

        private readonly IUserService _service;

        public UserController (IUserService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult FindAll(string query)
        {
            var users = _service.FindAll(query);
            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult FindById(int id)
        {
            var user = _service.FindById(id);
            return Ok(user);
        }

        [HttpPost]
        public IActionResult Save([FromBody] CreateUserDTO userDTO)
        {
            var result = _service.Save(userDTO);
            return Created($"api/users/{result.Id}" , result );
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id , [FromBody] UpdateUserDTO userUpdateDTO)
        {
            _service.Update(id, userUpdateDTO);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);
            return NoContent();
        }

        [HttpPatch("{id}")]
        public IActionResult AddSkill(int id , [FromBody] List<FindSkillDTO> findSkillDTO)
        {
            _service.AddSkills(id, findSkillDTO);
            return NoContent();
        }

        [HttpDelete("{id}/delete-skill")]
        public IActionResult DeleteSkill(int id , [FromBody] FindSkillDTO findSkillDto)
        {
            _service.DeleteSkill(id, findSkillDto);
            return NoContent();
        }

        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] Login login)
        {
            return NoContent();
        }
    }
}
