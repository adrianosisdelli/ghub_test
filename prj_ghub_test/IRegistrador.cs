using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_ghub_test
{
    public interface IRegistrador
    {
        void setInfo(string nome, string endereco, string cidade, string telefone);
    }
}
