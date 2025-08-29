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
    public partial class mainForm: Form
    {
        public mainForm()
        {
            
                InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Login login = new Login();

            var loginResult = login.ShowDialog();

            if (loginResult == DialogResult.Cancel || loginResult == DialogResult.None)
            {
                Application.Exit();
            }
            // TODO: This line of code loads data into the 'lAEMPRESADataSet.USUARIOS' table. You can move, or remove it, as needed.
            this.uSUARIOSTableAdapter.Fill(this.lAEMPRESADataSet.USUARIOS);

        }
        private void actualizarTabla()
        {
            SqlConnector consulta = new SqlConnector();
            string instruccion = "SELECT * FROM USUARIOS";
            DataTable dataTable = consulta.consultar(instruccion);
            this.uSUARIOSBindingSource.DataSource = dataTable;
            this.gridViewMain.Refresh();
        }


        private void agregarBtn_Click(object sender, EventArgs e)
        {
            AgregarFrm agregar= new AgregarFrm();
            agregar.ShowDialog();
            actualizarTabla();
        }
        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            Eliminar eliminar = new Eliminar();
            eliminar.ShowDialog();
            actualizarTabla();
        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            Modificar modificar = new Modificar();
            modificar.ShowDialog();
            actualizarTabla();
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
