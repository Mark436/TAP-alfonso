using System;
using DLLPractica2;
using System.Windows.Forms;

namespace practica2
{
    public partial class Menu: Form
    {
        public Menu()
        {
            InitializeComponent();
        }



        private void cargarButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileOpener=new OpenFileDialog();
            fileOpener.Filter = "Text Files|*.txt";
            fileOpener.Title = "Seleciona el archivo de texto";
            if (fileOpener.ShowDialog() == DialogResult.OK)
            {
                String ruta=fileOpener.FileName;
                DLLPractica2.DbManager.readFile(ruta);
                DisplayTextBox.Text = DLLPractica2.DbManager.Text;
                DisplayGridView.DataSource = DLLPractica2.DbManager.Table;
                return;
            }
            MessageBox.Show("No se ha seleccionado un archivo");
        }
    }
}
