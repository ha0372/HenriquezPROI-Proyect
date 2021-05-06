using CHenriquez01.MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHenriquez01.DAO
{
    class ClsDUserList
    {
        public List<UserList> cargarDatoUserList()

        {
            List<UserList> Lista;

            using (programacionEntities db = new programacionEntities())
            {
                Lista = db.UserList.ToList();


            }

            return Lista;
        }

        //public void SaveDatosUser(String Nombre, String Apellido, int Edad, String Pass)
        //{
        //    try
        //    {
        //        using (programacionEntities db = new programacionEntities())
        //        {

        //            UserList userList = new UserList();

        //            userList.NombreUsuario = Nombre;
        //            userList.Apellido = Apellido;
        //            userList.Edad = Edad;
        //            userList.Pass = Pass;

        //            db.UserList.Add(userList);
        //            db.SaveChanges();

        //            MessageBox.Show("SAVE");

        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

        public void SaveDatosUser(UserList user)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {

                    UserList userList = new UserList();

                    userList.NombreUsuario = user.NombreUsuario;
                    userList.Apellido = user.Apellido;
                    userList.Edad = user.Edad;
                    userList.Pass = user.Pass;

                    db.UserList.Add(userList);
                    db.SaveChanges();

                    MessageBox.Show("SAVE");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void deleteUser(int ID)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int eliminar = Convert.ToInt32(ID);
                    UserList userList = db.UserList.Where(x => x.Id == eliminar).Select(x => x).FirstOrDefault();

                    //userList = db.UserList.Find(eliminar);
                    db.UserList.Remove(userList);
                    db.SaveChanges();

                    MessageBox.Show("Eliminado");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void updateUser(UserList user)
        {
            try
            {


                using (programacionEntities db = new programacionEntities())
                {

                    int update = Convert.ToInt32(user.Id);
                    UserList userList = db.UserList.Where(x => x.Id == update).Select(x => x).FirstOrDefault();
                    //UserList list = new UserList();
                    //list = db.UserList.Find(2);

                    userList.NombreUsuario = user.NombreUsuario;
                    userList.Apellido = user.Apellido;
                    userList.Edad = user.Edad;
                    userList.Pass = user.Pass;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {


                MessageBox.Show(ex.ToString());


            }
        }
    }
}
