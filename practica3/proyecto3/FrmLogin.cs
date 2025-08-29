using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto3
{
    public partial class Login: Form
    {
        public Login()
        {
            
            InitializeComponent();
        }


        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
      

        private void loginBtn_Click(object sender, EventArgs e)
        {
            SqlConnector consultor = new SqlConnector();

            string instruccion = "SELECT * FROM USUARIOS WHERE Nombre='" + nombreTxtBox.Text + "' AND Contraseña='" + passwordTxtBox.Text + "'";

            DataTable dataTable=consultor.consultar(instruccion);

            if (dataTable.Rows.Count <= 0) { 
                MessageBox.Show("Usuario o contraseña incorrectos");
                return;
            }
            
            MessageBox.Show("Bienvenido " + nombreTxtBox.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

     
    }
}
