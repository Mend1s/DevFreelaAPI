namespace DevFreela.Core.Entities
{
    public class ProjectComment : BaseEntity
    {
        public ProjectComment(string content, int idProject, int idUser)
        {
            Content = content;
            IdProject = idProject;
            IdUser = idUser;

            CreateAt = DateTime.Now;
        }

        public string Content { get; private set; }
        public int IdProject { get; set; }
        public int IdUser { get; private set; }
        public DateTime CreateAt { get; private set; }

    }
}