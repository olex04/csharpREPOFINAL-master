using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoV_1
{
    public partial class Administrador
    {

        public Administrador()
        {

        }

        public Administrador(String username, String password, bool super)
        {
            this.username = username;
            this.password = password;
            this.superUser = super;
        }

        public override string ToString()
        {
            return username;
        }
    }
}
