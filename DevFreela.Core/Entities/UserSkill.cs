namespace DevFreela.Core.Entities
{
    public class UserSkill : BaseEntity
    {
        public UserSkill(int userId, int idSkill)
        {
            UserId = userId;
            IdSkill = idSkill;
        }

        public int UserId { get; private set; }
        public int IdSkill { get; private set; }
        public Skill Skill { get; private set; }

    }
}
