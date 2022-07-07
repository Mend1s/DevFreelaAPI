using DevFreela.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DevFreela.UnitTests.Core.Entities
{
    public class ProjectTests
    {
        [Fact]
        public void TestProjectStartWorks()
        {
            var project = new Project("Nome de Teste","Descrição de Teste", 1, 2, 10000);

            Assert.Equal(ProjectStatusEnum.Created, project.Status);
            Assert.Null(project.StartedAt);

            Assert.NotEmpty(project.Title);
            Assert.NotNull(project.Title);

            Assert.NotEmpty(project.Description);
            Assert.NotNull(project.Description);

            project.Start();

            Assert.Equal(ProjectStatusEnum.InProgress, project.Status);
            Assert.NotNull(project.StartedAt);

        }
    }
}
