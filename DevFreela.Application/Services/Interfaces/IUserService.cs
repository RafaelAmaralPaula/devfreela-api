using DevFreela.Application.DTOS.SkillDataTransferObject;
using DevFreela.Application.DTOS.UserDataTransferObject;

namespace DevFreela.Application.Services.Interfaces
{
    public interface IUserService
    {

        List<UserDTO> FindAll(string query);

        UserDTO FindById(int id);

        CreateUserDTO Save(CreateUserDTO userDTO);

        void Update(int id, UpdateUserDTO userUpdateDTO);

        void Delete(int id);

        void AddSkills(int id , List<FindSkillDTO> skills);

        void DeleteSkill(int id, FindSkillDTO skillS);


    }
}
