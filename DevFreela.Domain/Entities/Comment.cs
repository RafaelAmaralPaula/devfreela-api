namespace DevFreela.Domain.Entities
{
    public class Comment
    {
        public int Id { get; set; } 

        public string Content { get;  set; }

        public Project Project { get;  set; }

        public User User { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public Comment(string content ) {
            Content = content;
            CreatedAt = DateTime.Now;
        }

    }
}
