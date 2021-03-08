using CHenriquez01.DOMINIO;
using CHenriquez01.NEGOCIO;
using CHenriquez01.VISTA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHenriquez01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {

            Login log = new Login();

            log.User = txtUser.Text;
            log.Password = txtPass.Text;

            ClsLogin clsL = new ClsLogin();

            int evaluacion = clsL.acceso(log);

            if (evaluacion == 1)
            {

                MessageBox.Show("Welcome");
                FrmMenu frmM = new FrmMenu();
                frmM.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("No se encuentra en el sistema");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


