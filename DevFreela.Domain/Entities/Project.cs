using DevFreela.Domain.Enums;

namespace DevFreela.Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }

        public string Title { get;  set; }

        public string Description { get;  set; }

        public User Client { get;  set; }

        public User Freelancer { get;  set; }

        public DateTime CreatedAt { get; set; }

        public decimal TotalCost { get;  set; }

        public ProjectStatusEnum Status { get;  set; }

        public List<Comment> Comments { get;  set; }

        public DateTime StartedAt { get;  set; }

        public DateTime FinishedAt { get;  set; }


        public Project() {
            
        }

        public Project(string title, string description, User idClient, User idFreelancer, decimal totalCost)
        {
            Title = title;
            Description = description;
            Client = idClient;
            Freelancer = idFreelancer;
            TotalCost = totalCost;

            CreatedAt = DateTime.Now;
            Status = ProjectStatusEnum.Created;
            Comments = new List<Comment>();
        }

        public void Cancel()
        {
            if(Status == ProjectStatusEnum.InProgress)
            {
                Status = ProjectStatusEnum.Cancelled;
            }
        }

        public void Finish()
        {
            if(Status == ProjectStatusEnum.InProgress)
            {
                Status = ProjectStatusEnum.Finished;
                FinishedAt = DateTime.Now;
            }
        }

        public void Start()
        {
            if(Status == ProjectStatusEnum.Created)
            {
                Status = ProjectStatusEnum.InProgress;
                StartedAt = DateTime.Now;
            }
        }

        public void Update(string title, string description, decimal totalCost)
        {
            Title = title;
            Description = description;
            TotalCost = totalCost;
        }
    }
}
