namespace DotnetAT.Models.Dominio
{
    public class Funcionario
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string  Email { get; set;}
        public double Salario { get; set;}
        public DateTime DataDaContratacao { get; set;}
        public string Cargo { get; set; }
    }
}
