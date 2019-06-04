using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoV_1
{
    public partial class Cliente
    {

        private BaseDeDadosContainer database = new BaseDeDadosContainer();

        public decimal totalGastoNoStand
        {
            get
            {
                decimal totalInterno = 0;
                decimal totalInternoOficina = 0;
                decimal totalInternoAluguer = 0;
                decimal totalInternoVendas = 0;
                foreach (Venda itemVendas in this.Vendas)
                {
                    totalInternoVendas += itemVendas.Valor;
                }
                foreach (Aluguer itemAluguer in this.Alugueres)
                {
                    totalInternoAluguer += itemAluguer.Valor;
                }
                //CALCULAR QUANTO GASTOU NA OFICINA POR CARRO
                foreach (CarroOficina itemCarro in this.CarrosOficina)
                {
                    totalInternoOficina += itemCarro.totalCarro;
                }
                totalInterno = totalInternoAluguer + totalInternoVendas + totalInternoOficina;
                return totalInterno;
            }
        }

        public decimal totalGastoVendas
        {
            get
            {
                decimal totalInterno = 0;
                foreach (Venda itemVendas in this.Vendas)
                {
                    totalInterno += itemVendas.Valor;
                }
                return totalInterno;
            }
        }

        public decimal totalGastoAlugueres
        {
            get
            {
                decimal totalInterno = 0;
                foreach (Aluguer itemAluguer in this.Alugueres)
                {
                    totalInterno += itemAluguer.Valor;
                }
                return totalInterno;
            }
        }
        
        public decimal totalGastoOficina
        {
            get
            {
                decimal totalInterno = 0;
                foreach (CarroOficina itemCarro in this.CarrosOficina)
                {
                    totalInterno += itemCarro.totalCarro;
                }
                return totalInterno;
            }
        }

        public Cliente(String nome, String nif, String morada, String contacto)
        {
            this.Nome = nome;
            this.NIF = nif;
            this.Morada = morada;
            this.Contacto = contacto;
            this.CarrosOficina = new HashSet<CarroOficina>();
            this.Alugueres = new HashSet<Aluguer>();
            this.Vendas = new HashSet<Venda>();
        }
        public override string ToString()
        {
            return Nome + " ( " + NIF + " )";
        }
    }
}
