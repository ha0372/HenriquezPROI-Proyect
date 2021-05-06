using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHenriquez01.DAO;
using CHenriquez01.DOMINIO;

namespace CHenriquez01.NEGOCIO
{
    class ClsLogin
    {
        ClsListaUsuarios clsLu = new ClsListaUsuarios();

        public int acceso(Login log)
        {
            int estado = 0;
            for (int i=0; i< clsLu.user.Length;i++) { 
            if (log.User.Equals(clsLu.user[i]) && log.Password.Equals(clsLu.pass[i]))
                estado = 1;
            {

            }
            }
            return estado;
        }

    }
}
