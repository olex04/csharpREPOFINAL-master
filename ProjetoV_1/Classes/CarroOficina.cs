using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoV_1
{
    public partial class CarroOficina
    {
        
        public CarroOficina(string numeroChasis, string marca, string modelo, string combustivel, string maticula, Decimal kms)
        {
            this.Servicos = new HashSet<Servico>();
            this.NumeroChassis = numeroChasis;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Combustível = combustivel;
            this.Matricula = maticula;
            this.Kms = kms;
        }

        public decimal totalCarro
        {
            get
            {
                decimal totalServicos = 0;
                foreach (Servico itemServico in this.Servicos)
                {
                    foreach (Parcela itemParcela in itemServico.Parcelas)
                    {
                        totalServicos += itemParcela.Valor;
                    }
                }
                return totalServicos;
            }
        }

        public override string ToString()
        {
            return Marca + '(' + Matricula + ')';
        }
    }
}
