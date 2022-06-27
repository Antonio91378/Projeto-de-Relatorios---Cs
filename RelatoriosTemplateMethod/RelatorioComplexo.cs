namespace RelatoriosTemplateMethod
{
    public class RelatorioComplexo : TemplateDeRelatorioIndefinido
    {
        public override string ParametrosDeRelatorio(ContaBancaria conta)
        {
            return "Cabecalho :" + "\n" + "Nome do banco: " + conta.NomeDoBanco
            + "\n" + "Endereco :" + conta.Endereco + "\n"
            + "Telefone :" + conta.Telefone + "\n"
            + "Rodape:" + "\n" + "Email :" + conta.Email + "\n"
            + "Data:" + conta.Data.ToString() + "\n" + "\n" + "=========================";
        }
    }
}