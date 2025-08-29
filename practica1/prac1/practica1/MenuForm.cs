using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1
{
    public partial class MenuForm: Form
    {
        public MenuForm()
        {

            LoginForm login = new LoginForm();

            login.ShowDialog();
            
            if (login.LoggedIn)
            {
                InitializeComponent();
            }
            else
            {
                Application.Exit();
            }
            

        }



        private void AlumnosStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnosForm alumnos = new AlumnosForm();
            alumnos.ShowDialog();
        }

        private void SalirStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CapturaMenuStripItem_Click(object sender, EventArgs e)
        {
            CaptureForm captura = new CaptureForm();
            captura.ShowDialog();
        }

        private void ConsultaMenuStripItem_Click(object sender, EventArgs e)
        {
            ConsultasForm consulta = new ConsultasForm();
            consulta.ShowDialog();
        }


    }
}
