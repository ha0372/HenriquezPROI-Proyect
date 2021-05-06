using CHenriquez01.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHenriquez01.DAO
{
    class ClsDJoin
    {
        public List<List<object>> JoinUsuarioType()
        {
            List<List<object>> Matriz = new List<List<object>>();
            using(programacionEntities db = new programacionEntities())
            {
                var lista = (from usuario in db.UserList
                            from type in db.typeOfUser
                            where usuario.IdTypeOfUser == type.idTypeOfUser

                            select new
                            {
                                usuario.Id,
                                usuario.NombreUsuario,
                                type.idTypeOfUser,
                                type.TypeofUserName

                            }).ToList();

                for (int i = 0; i < lista.Count; i++)
                {
                    Matriz.Add(new List<object>()
                    {
                        lista[i].Id, lista[i].NombreUsuario, lista[i].idTypeOfUser,lista[i].TypeofUserName

                    });
                }
            }

            return Matriz;
        }
    }
}
