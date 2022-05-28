namespace DevFreela.Application.Services.Interfaces
{
    public class ProjectViewModel
    {
        public ProjectViewModel(string title, DateTime createAt)
        {
            Title = title;
            CreateAt = createAt;
        }

        public string Title { get; private set; }
        public DateTime CreateAt { get; private set; }
    }
}