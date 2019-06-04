using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoV_1
{
    public partial class Servico
    {

        public Servico(DateTime dataEntrada, DateTime dataSaida, string tipo, CarroOficina carroSelecionado)
        {
            this.Parcelas = new HashSet<Parcela>();
            this.DataEntrada = dataEntrada;
            this.DataSaida = dataSaida;
            this.Tipo = tipo;
            this.EnviouFatura = false;
            this.CarroOficina = carroSelecionado;
        }

        public decimal TotalServico
        {
            get
            {
                decimal totalInterno = 0;
                foreach (Parcela item in this.Parcelas)
                {
                    totalInterno += item.Valor;
                }
                return totalInterno;
            }
        }


        public override string ToString()
        {
            return Tipo + "(" + DataEntrada + "/" + DataSaida + ")";
        }
    }
}
