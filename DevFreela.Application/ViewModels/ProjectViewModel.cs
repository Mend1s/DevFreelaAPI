namespace DevFreela.Application.Services.Interfaces
{
    public class ProjectViewModel
    {
        public ProjectViewModel(int id, string title, DateTime createAt)
        {
            Id = id;
            Title = title;
            CreateAt = createAt;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }
        public DateTime CreateAt { get; private set; }
    }
}