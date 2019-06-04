using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoV_1
{
    public partial class Venda
    {
        public Venda()
        {

        }

        public Venda(string estado, Decimal valor, DateTime data, CarroVenda carroVendaSelecionado)
        {
            this.Estado = estado;
            this.Valor = valor;
            this.Data = data;
            this.CarroVenda = carroVendaSelecionado;
            this.EnviouFatura = false;
        }

        public override string ToString()
        {
            return Valor + "(" + Estado + ")" + " " + Data;
        }


    }
}
