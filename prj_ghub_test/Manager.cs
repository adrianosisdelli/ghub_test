using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prj_ghub_test
{
    public class Manager
    {
        public string nome { get; private set; }
        public string endereco { get; private set; }
        public string cidade { get; private set; }
        public string telefone { get; private set; }

        public void setData(IRegistrador registrador)
        {
            registrador.setInfo(this.nome, this.endereco, this.cidade, this.telefone);
        }
    }
}
