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
    public partial class FrmJoinLista : Form
    {
        public FrmJoinLista()
        {
            InitializeComponent();
           
        }

        private void FrmJoinLista_Load(object sender, EventArgs e)
        {
            load();
        }

        void load(){

            dataGridView1.Rows.Clear();
            using(programacionEntities bd = new programacionEntities())
            {
                var consulta = (from user in bd.UserList
                               from type in bd.typeOfUser
                               where user.IdTypeOfUser == type.idTypeOfUser && user.NombreUsuario.Contains(textBox1.Text)
                               select new
                               {
                                   user.NombreUsuario,
                                   type.TypeofUserName
                               }).ToList();

                foreach (var iteracion  in consulta)
                {
                    dataGridView1.Rows.Add(iteracion.NombreUsuario, iteracion.TypeofUserName);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            load();
        }
    }
}
