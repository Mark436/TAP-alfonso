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
    public partial class CaptureForm : Form
    {
        public CaptureForm()
        {
            InitializeComponent();
        }

        private void ResultadoBtn_Click(object sender, EventArgs e)
        {
            AgeTextBox.Text=String.Join("",
                (radioBtnGroup1.SelectedValue + 
                radioBtnGroup2.SelectedValue + 
                radioBtnGroup3.SelectedValue + 
                radioBtnGroup4.SelectedValue +
                radioBtnGroup5.SelectedValue +
                radioBtnGroup6.SelectedValue +
                radioBtnGroup7.SelectedValue +
                radioBtnGroup8.SelectedValue +
                radioBtnGroup9.SelectedValue +
                radioBtnGroup10.SelectedValue));
        }

        private void SalirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

