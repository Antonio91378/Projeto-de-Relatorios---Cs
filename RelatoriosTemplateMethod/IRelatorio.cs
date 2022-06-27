using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelatoriosTemplateMethod
{
    public interface IRelatorio
    {
        void ApresentaRelatorio(ContaBancaria conta);
    }
}
