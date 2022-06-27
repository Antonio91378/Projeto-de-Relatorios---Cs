namespace RelatoriosTemplateMethod
{
    public class RelatorioSimples : TemplateDeRelatorioIndefinido
    {
        public override string ParametrosDeRelatorio(ContaBancaria conta)
        {
            return "Cabecalho :" + "\n" + "Nome do banco :" + conta.NomeDoBanco + "\n"
            + "rodape :" + conta.Telefone + "\n" + "\n" + "=========================";
        }
    }
}