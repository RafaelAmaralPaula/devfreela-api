using DevFreela.Application.DTOS.ProjectDataTransferObject;
using DevFreela.Application.DTOS.UserDataTransferObject;
using DevFreela.Domain.Entities;

namespace DevFreela.Application.DTOS.CommentDataTransferObject
{
    public class CommentDTO
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public ProjectDTO Project { get; set; }
        public UserDTO User { get; set; }

        public CommentDTO(int id , string content , ProjectDTO project , UserDTO user )
        {
            Id = id;
            Content = content;
            Project = project;
            User = user;
        }

        public CommentDTO(Comment entity )
        {
            Id = entity.Id;
            Content = entity.Content;
            Project = new ProjectDTO(entity.Project);
            User = new UserDTO(entity.User);

        }
        

    }
}
