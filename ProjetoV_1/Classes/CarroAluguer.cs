using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoV_1
{
    public partial class CarroAluguer
    {

        public bool EmUso;

        public CarroAluguer(String numeroChassis, String marca, String modelo, String combustivel, String estado, String matricula)
        {
            this.NumeroChassis = numeroChassis;
            this.Marca = marca;
            this.Modelo = modelo;
            this.Combustível = combustivel;
            this.Estado = estado;
            this.Matricula = matricula;
            this.Aluguer = new HashSet<Aluguer>();
        }

        public override string ToString()
        {
            return Marca + " ( " + Matricula + " )";
        }
        

    }
}
