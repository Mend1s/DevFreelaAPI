using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Application.InputModels
{
    public class CreateUserInputModel
    {
        public string Name { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
    }
}
