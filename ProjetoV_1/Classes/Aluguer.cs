using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoV_1
{
    public partial class Aluguer
    {


        public Aluguer()
        {

        }

        public Aluguer(DateTime dataInicio, decimal valor, decimal kms, DateTime dataFim, Cliente clienteSelecionado, CarroAluguer carroAluguerSelecionado)
        {
            this.DataInicio = dataInicio;
            this.Valor = valor;
            this.Kms = kms;
            this.DataFim = dataFim;
            this.Cliente = clienteSelecionado;
            this.CarroAluguer = carroAluguerSelecionado;
            this.EnviouFatura = false;
        }

        public override string ToString()
        {
            return DataInicio.ToShortDateString() + " " + Valor +" €";
        }

    }
}
