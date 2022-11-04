
using DevFreela.Application.DTOS.ProjectDataTransferObject;
using DevFreela.Application.Services.Interfaces;
using DevFreela.Domain.Entities;
using DevFreela.Infrastructure.Persistences;
using Microsoft.EntityFrameworkCore;

namespace DevFreela.Application.Services.Implementations
{
    public class ProjectService 
    {

        /*
       
        private readonly DevFreelaDbContext _dbContext;

        public ProjectService(DevFreelaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateComment(CommentDTO commentDTO)
        {
            var comment = new Comment();
            _dbContext.Comments.Add(comment);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            project.Cancel();
            _dbContext.SaveChanges();


        }   

        public List<ProjectDTO> FindAll(string query)
        {
            var entity = _dbContext.Projects;

            var projectDTO = entity
                .Select(p => new ProjectDTO(p.Title, p.Description
                                            , p.Client.Id, p.Freelancer.Id, p.TotalCost))
                .ToList();

            return projectDTO;
                     
        }

        public ProjectDTO FindById(int id)
        {
            var entity = _dbContext.Projects
                .Include(p => p.Client)
                .Include(p => p.Freelancer)
                .SingleOrDefault(p => p.Id == id);


            if (entity == null) { return null; }

            var projectDTO = new ProjectDTO(entity.Title , entity.Description
                                            ,entity.Client.Id , entity.Freelancer.Id , entity.TotalCost);

            return projectDTO;
        }

        public void Finish(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            project.Finish();
            _dbContext.SaveChanges();
        }

        public int Save(ProjectDTO projectDTO)
        {
            var project = new Project();
            _dbContext.Projects.Add(project);

            _dbContext.SaveChanges();
            return project.Id;
        }

        public void Start(int id)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            project.Start();
            _dbContext.SaveChanges();
        }

        public void Update(int id , ProjectDTO projectUpdateDTO)
        {
            var project = _dbContext.Projects.SingleOrDefault(p => p.Id == id);
            project.Update(projectUpdateDTO.Title, projectUpdateDTO.Description, projectUpdateDTO.TotalCost);

            _dbContext.SaveChanges();
        }

        */
        
        
    }
        
}
