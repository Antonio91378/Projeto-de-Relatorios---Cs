using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatoriosTemplateMethod
{
    public abstract class TemplateDeRelatorioIndefinido : IRelatorio
    {

        public abstract string ParametrosDeRelatorio(ContaBancaria conta);


        public void ApresentaRelatorio(ContaBancaria conta)
        {
            System.Console.WriteLine(ParametrosDeRelatorio(conta));
        }
    }
}