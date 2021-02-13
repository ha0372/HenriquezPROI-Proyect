using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHenriquez01.DOMINIO;

namespace CHenriquez01.NEGOCIO
{
    class ClsLogin
    {
        Login log = new Login();

        public int acceso()
        {
            int estado = 0;
            if (log.User.Equals("william") && log.Password.Equals("123"))
                estado = 1;
            {

            }
            return estado;
        }

    }
}
