using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoV_1
{
    public partial class Parcela
    {

        public Parcela()
        {

        }

        public Parcela(decimal valor, string descricao)
        {
            this.Valor = valor;
            this.Descricao = descricao;
        }
        public override string ToString()
        {
            return Descricao + "(" + Valor + ")";
        }
    }
}
