using CHenriquez01.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                } 
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                using (programacionEntities db = new programacionEntities())
                {

                    UserList userList = new UserList();
                    int eliminar = Convert.ToInt32(txtId.Text);
                    userList = db.UserList.Find(eliminar);
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
    }
}
