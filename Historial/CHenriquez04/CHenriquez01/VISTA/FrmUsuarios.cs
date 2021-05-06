using CHenriquez01.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHenriquez01.VISTA
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            Carga();
        }

        void Carga()
            {
            dataGridView1.Rows.Clear();
            using (programacionEntities db = new programacionEntities())
            {
                var Lista = db.UserList.ToList();

                foreach (var iteracion in Lista)
                {

                    dataGridView1.Rows.Add(iteracion.Id,iteracion.NombreUsuario,iteracion.Apellido,iteracion.Edad,iteracion.Pass);


                }
            }
        }

        

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using(programacionEntities db = new programacionEntities()) {

                //for (int i=0; i<=100; i++ ) { }
                try { 
                UserList userList = new UserList();

                userList.NombreUsuario = txtNombre.Text;
                userList.Apellido = txtApellido.Text;
                userList.Edad = Convert.ToInt32(txtEdad.Text);
                userList.Pass = txtPass.Text;

                db.UserList.Add(userList);
                db.SaveChanges();

                    MessageBox.Show("SAVE"); 

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                Carga();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {
                    int eliminar = Convert.ToInt32(txtId.Text);
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
            Carga();
        }


        private void txtActualizar_Click(object sender, EventArgs e)
        {
             try {


                using (programacionEntities db = new programacionEntities())
                {

                    int update = Convert.ToInt32(txtId.Text);
                    UserList userList = db.UserList.Where(x => x.Id == update).Select(x => x).FirstOrDefault();
                    //UserList list = new UserList();
                    //list = db.UserList.Find(2);
                    userList.NombreUsuario = txtNombre.Text;
                    userList.Apellido = txtApellido.Text;
                    userList.Edad = Convert.ToInt32(txtEdad.Text);
                    userList.Pass = txtPass.Text;
                    db.SaveChanges();
                }

             } catch (Exception ex) {


                    MessageBox.Show(ex.ToString());
                
            
             }
            Carga();

        }
    }
}
