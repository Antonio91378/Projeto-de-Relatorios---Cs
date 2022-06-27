namespace RelatoriosTemplateMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            var conta1 = new ContaBancaria("Antonio", "Santander", "Rua buginganga", "38998125366", "a@gmail.com", DateTime.Today, true);
            var conta2 = new ContaBancaria("Brunna", "Caixa", "Rua babugings", "38998125363", "b@gmail.com", DateTime.Today, false);
            var relatorioSimples = new RelatorioSimples();
            var relatorioComplexo = new RelatorioComplexo();
            relatorioSimples.ApresentaRelatorio(conta1);
            relatorioComplexo.ApresentaRelatorio(conta1);
            relatorioSimples.ApresentaRelatorio(conta2);
            relatorioComplexo.ApresentaRelatorio(conta2);
        }
    }
}