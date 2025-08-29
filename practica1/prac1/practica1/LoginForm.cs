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
    public partial class LoginForm: Form
    {
        private bool _loggedIn=false;
        public bool LoggedIn { get { return _loggedIn; } }
        public LoginForm()
        {
            this.FormClosing += LoginForm_Closing;
            InitializeComponent();
        }
        private void LoginForm_Closing(object sender, FormClosingEventArgs e)
        {
            if(!LoggedIn)Application.Exit();
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IniciarBtn_Click(object sender, EventArgs e)
        {
            if (UserTextBox.Text == "marcos" && PasswordTextBox.Text == "123") 
            {
                this._loggedIn = true;
                this.Close();
                return;
            }
            MessageBox.Show("Usuario o contraseña incorrectos");
        }

    }
}
