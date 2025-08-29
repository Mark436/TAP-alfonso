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
    public partial class ConsultasForm: Form
    {
        public ConsultasForm()
        {
            InitializeComponent();
        }
        private readonly string[] alumnos = {
            "Juan Carlos Pérez López",
            "María Fernanda González Ramírez",
            "Carlos Eduardo Herrera Torres",
            "Ana Sofía Martínez Chávez",
            "Luis Alberto Rodríguez Mendoza",
            "Sofía Isabel Ramírez Flores",
            "Jorge Andrés Méndez Castro",
            "Fernanda Alejandra López Ortega",
            "Ricardo Antonio Torres Jiménez",
            "Gabriela Paola Vázquez Salazar",
            "Alejandro Javier Morales Rivera",
            "Valeria Beatriz Domínguez Pineda",
            "Diego Armando Soto Aguilar",
            "Andrea Guadalupe Ríos Herrera",
            "Fernando José Navarro Cruz",
            "Jessica Patricia Álvarez Guzmán",
            "Emilio Ricardo Escobar Rojas",
            "Daniela Estefanía Ortega Méndez",
            "Roberto Daniel Gutiérrez Luna",
            "Laura Vanessa Silva Carrasco",
            "Manuel Alejandro Castro Naranjo",
            "Paola Cristina Hernández Suárez",
            "Hugo Leonardo Medina Estrada",
            "Camila Renata Fuentes Orozco",
            "Arturo Sebastián Villanueva Reyes",
            "Elena Montserrat Castañeda Morales",
            "Oscar Adrián Serrano Blanco"
        };

        private void MateriasComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GruposListBox.Items.Clear();
            GruposListBox.Items.Add("Grupo A");
            GruposListBox.Items.Add("Grupo B");
            GruposListBox.Items.Add("Grupo C");
        }


        private void ImprimirBtn_Click(object sender, EventArgs e)
        {
            var gruposIndexes= GruposListBox.SelectedIndices;
            int indexMateria = MateriasComboBox.SelectedIndex;
            
            foreach(int indexGrupo in gruposIndexes) {
            int headIndex = (indexMateria * 9) + (indexGrupo * 3);

            AlumnosListBox.Items.Add(alumnos[headIndex]);
            AlumnosListBox.Items.Add(alumnos[headIndex + 1]);
            AlumnosListBox.Items.Add(alumnos[headIndex + 2]);
            }
        }

        private void LimpiarBtn_Click(object sender, EventArgs e)
        {
            AlumnosListBox.Items.Clear();
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
