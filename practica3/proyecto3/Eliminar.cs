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
    public partial class Eliminar: Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void Eliminar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'lAEMPRESADataSet.USUARIOS' table. You can move, or remove it, as needed.
            this.uSUARIOSTableAdapter.Fill(this.lAEMPRESADataSet.USUARIOS);

        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            SqlConnector consultor= new SqlConnector();
            string query = "DELETE FROM dbo.Usuarios where Clave='"+claveTxtBox.Text+"'";
            
            int Resultado = consultor.ejecutarNonQuery(query);
            
            if (Resultado > 0)
            {
                MessageBox.Show("Eliminado Correctamente");
            }
            else
            {
                MessageBox.Show("No se encontró ningun usuario con esa clave");
            }
            string instruccion = "SELECT * FROM USUARIOS";
            DataTable dataTable = consultor.consultar(instruccion);
            this.uSUARIOSBindingSource.DataSource = dataTable;
            this.gridEliminar.Refresh();
        }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
