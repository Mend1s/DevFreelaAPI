using MediatR;

namespace DevFreela.Application.Commands.FinishProject
{
    public class FinishProjectCommand : IRequest<int>
    {
        public FinishProjectCommand(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
