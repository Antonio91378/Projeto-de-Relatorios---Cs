namespace RelatoriosTemplateMethod
{
    public class ContaBancaria
    {
        public ContaBancaria(string nome, string nomeDoBanco, string endereco, string telefone, string email, DateTime data, bool exigenciaDeRelatorioComplexo)
        {
            this.Nome = nome;
            this.NomeDoBanco = nomeDoBanco;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
            this.Data = data;
            this.ExigenciaDeRelatorioComplexo = exigenciaDeRelatorioComplexo;
        }

        public string Nome { get; }
        public string NomeDoBanco { get; }
        public string Endereco { get; }
        public string Telefone { get; }
        public string Email { get; }
        public DateTime Data { get; }

        public bool ExigenciaDeRelatorioComplexo { get; }

    }
}