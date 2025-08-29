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
    public partial class Modificar: Form
    {
        public Modificar()
        {
            InitializeComponent();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lAEMPRESADataSet.USUARIOS' table. You can move, or remove it, as needed.
            this.uSUARIOSTableAdapter.Fill(this.lAEMPRESADataSet.USUARIOS);

        }

        private void modificarBtn_Click(object sender, EventArgs e)
        {
            SqlConnector modificar = new SqlConnector();
            string cad;
            int validar = 0;
            if (!string.IsNullOrEmpty(nombreTxtBox.Text))
            {
                cad = "update dbo.Usuarios set Nombre = '" + nombreTxtBox.Text + "' where Clave ='" + claveTxtBox.Text + "'";
                validar = modificar.ejecutarNonQuery(cad);
                //MessageBox.Show(Clave.ToString());
            }
            if (!string.IsNullOrEmpty(direccionTxtBox.Text))
            {
                cad = "update dbo.Usuarios set Direccion = '" + direccionTxtBox.Text + "' where Clave ='" + claveTxtBox.Text + "'";
                validar = modificar.ejecutarNonQuery(cad);
            }
            if (!string.IsNullOrEmpty(passwordTxtBox.Text))
            {
                cad = "update dbo.Usuarios set Contraseña = '" + passwordTxtBox.Text + "' where Clave ='" + claveTxtBox.Text + "'";
                validar = modificar.ejecutarNonQuery(cad);
            }
            if (validar > 0)
            {
                MessageBox.Show("Modificado correctamente");
            }
            else
            {
                MessageBox.Show("Error: Seleccione una clave");
            }
            string instruccion = "SELECT * FROM USUARIOS";
            DataTable dataTable = modificar.consultar(instruccion);
            this.uSUARIOSBindingSource.DataSource = dataTable;
            this.gridModificar.Refresh();

        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
