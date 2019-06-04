using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoV_1
{
    public partial class CarroVenda
    {
        public CarroVenda()
        {

        }
        public CarroVenda(string numChasis, String marca, String modelo, String combustivel, String extras)
        {
            this.NumeroChassis = numChasis;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Combustível = combustivel;
            this.Extras = extras;
            this.JaFoiVendido = false;
        }

        public override string ToString()
        {
            if (this.JaFoiVendido == false)
                return Marca + '(' + Modelo + ')' + " - Disponível";
            else
                return Marca + '(' + Modelo + ')' + " - Vendido";
        }
    }
}
