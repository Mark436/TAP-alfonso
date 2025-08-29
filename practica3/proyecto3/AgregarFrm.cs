using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto3
{
    public partial class AgregarFrm: Form
    {
        public AgregarFrm()
        {
            InitializeComponent();
        }

        private void EditarFrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lAEMPRESADataSet.USUARIOS' table. You can move, or remove it, as needed.
            this.uSUARIOSTableAdapter.Fill(this.lAEMPRESADataSet.USUARIOS);

        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            if (HayCamposVacios())
            {
                MessageBox.Show("Error: Todos los campos son obligatorios", "Validación",
                               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnector inserta = new SqlConnector();
            string cad = "INSERT INTO dbo.Usuarios(Clave, Nombre, Direccion, Contraseña) " +
            "VALUES('" + idTxtBox.Text.Replace("'", "''") + "', '" +
            nombreTxtBox.Text.Replace("'", "''") + "', '" +
                         direccionTxtBox.Text.Replace("'", "''") + "', '" +
                         passwordTxtBox.Text.Replace("'", "''") + "')";
            inserta.consultar(cad);

            MessageBox.Show("Agregado correctamente");
            DialogResult = DialogResult.OK;
            string instruccion = "SELECT * FROM USUARIOS";
            DataTable dataTable = inserta.consultar(instruccion);
            this.uSUARIOSBindingSource.DataSource = dataTable;
            this.gridAgregar.Refresh();

        }
        private bool HayCamposVacios()
        {

            foreach (Control control in this.Controls)
            {

                if (control is System.Windows.Forms.TextBox && string.IsNullOrWhiteSpace(control.Text))
                {
                    return true;
                }
            }
            return false;
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
