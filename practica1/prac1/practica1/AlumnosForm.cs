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
    public partial class Alumnos: Form
    {
        public Alumnos()
        {
            InitializeComponent();
        }
        private readonly String[] nombres = { "Alvaro Alain","Marcos Javier","Joseph de Jesus"};
        private readonly String[] apellidos = { "Rendon Bejarano","Ochoa Robles","Perez Madrid" };
        private readonly String[] semestres = {"4to semestre","2do semestre","6to semestre" };
        private readonly String[] turnos= {"vespertino","matutino","vespertino" };
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            NombresTextBox.Text = nombres[AlumnosComboBox.SelectedIndex];
            ApellidosTextBox.Text = apellidos[AlumnosComboBox.SelectedIndex];
            SemestreTextBox.Text = semestres[AlumnosComboBox.SelectedIndex];
            TurnoTextBox.Text = turnos[AlumnosComboBox.SelectedIndex];
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
