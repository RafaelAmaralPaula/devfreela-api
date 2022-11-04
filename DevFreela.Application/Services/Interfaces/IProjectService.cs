

using DevFreela.Application.DTOS.CommentDataTransferObject;
using DevFreela.Application.DTOS.ProjectDataTransferObject;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IProjectService
    {

        List<ProjectDTO> FindAll(string query);

        ProjectDTO FindById(int id);

        int Save(ProjectDTO projectDTO);

        void Update(int id , ProjectDTO projectUpdateDTO);

        void Delete(int id);

        void CreateComment(CommentDTO commentDTO);

        void Start(int id);

        void Finish(int id);

    }
}
