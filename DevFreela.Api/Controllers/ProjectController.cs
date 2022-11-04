
using DevFreela.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Api.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectController : ControllerBase
    {
        /*

        private readonly IProjectService _service;

        public ProjectController(IProjectService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult FindAll(string query)
        {
            var projects = _service.FindAll(query);
            return Ok(projects);
        }

        [HttpGet("{id}")] 
        public IActionResult FindById(int id)
        {
            var project = _service.FindById(id);

            if(project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        [HttpPost]
        public IActionResult Save([FromBody] ProjectDTO projectDTO)
        {
            if (projectDTO.Title.Length >= 50)
            {
                return BadRequest();
            }

            var id = _service.Save(projectDTO);

            return CreatedAtAction(nameof(FindById) , new { id = id} , projectDTO);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id , ProjectDTO projectUpdateDTO )
        {
            if(projectUpdateDTO.Description.Length > 200)
            {
                return BadRequest();
            }

            _service.Update(id, projectUpdateDTO);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.Delete(id);

            return NoContent();
        }

        [HttpPost("{id}/comment")]
        public IActionResult CreateComment (int id , [FromBody] CommentDTO commentDTO)
        {
            _service.CreateComment(commentDTO);

            return NoContent();
        }

        [HttpPut("{id}/start")]
        public IActionResult Start(int id)
        {
            _service.Start(id);
            return NoContent();
        }

        [HttpPut("{id}/finish")]
        public IActionResult Finish(int id)
        {
            _service.Finish(id);
            return NoContent();
        }

        */
    }
}
