namespace CustoFuncionarioApp.Models
{
    public class Funcionario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public decimal Desconto { get; set; }
        public decimal Beneficio { get; set; }

    }
}
