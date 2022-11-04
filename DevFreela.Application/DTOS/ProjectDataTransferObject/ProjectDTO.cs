using DevFreela.Application.DTOS.CommentDataTransferObject;
using DevFreela.Application.DTOS.UserDataTransferObject;
using DevFreela.Domain.Entities;

namespace DevFreela.Application.DTOS.ProjectDataTransferObject
{
    public class ProjectDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public UserDTO Client { get; set; }
        public UserDTO Freelancer { get; set; }
        public decimal TotalCost { get; set; }
        public IList<CommentDTO> Comments { get; set; }

        public ProjectDTO() { }

        public ProjectDTO(int id , string title , string description , UserDTO client , UserDTO freelancer , decimal totalCost) 
        {
            Id = id;
            Title = title;
            Description = description;
            Client = client;
            Freelancer = freelancer;
            TotalCost = totalCost;
        }

        public ProjectDTO(Project entity) 
        {
            Id = entity.Id;
            Title = entity.Title;
            Description = entity.Description;
            Client = new UserDTO(entity.Client);
            Freelancer = new UserDTO(entity.Freelancer);

        }

        public ProjectDTO(Project entity , List<Comment> comments) : this(entity)
        {
            comments.ForEach(comments => this.Comments.Add(new CommentDTO(comments)));

        }
    }
}
