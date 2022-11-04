using DevFreela.Application.DTOS.SkillDataTransferObject;

namespace DevFreela.Application.Services.Interfaces
{
    public interface ISkillService
    {

        List<SkillDTO> FindAll();

        SkillDTO Save(SkillDTO skillDTO);

        SkillDTO FindById(int id);

        void Update(int id , SkillDTO skillDTO);

        void Delete(int id);

    }
}
