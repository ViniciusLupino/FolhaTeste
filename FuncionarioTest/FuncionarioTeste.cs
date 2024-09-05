using CustoFuncionarioApp.Models;

namespace FuncionarioTest
{
    public class FuncionarioTeste
    {
        [Fact]
        public void Teste()
        {
            Assert.Equal(900, CustoFuncionarioApp.Controllers.FuncionariosController.Salario(1000, 200, 100));
            Assert.Equal(2000, CustoFuncionarioApp.Controllers.FuncionariosController.Salario(1000, 200, 1200));
        }
    }
}