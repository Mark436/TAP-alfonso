using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1
{
    public partial class RadioBtnGroup: UserControl
    {
        private int _selectedValue;
        public int SelectedValue { get { return _selectedValue; } }
        public RadioBtnGroup()
        {
            InitializeComponent();
        }

        private void RadBtnNum5_CheckedChanged(object sender, EventArgs e)
        {
            _selectedValue = 5;
        }

        private void RadBtnNum4_CheckedChanged(object sender, EventArgs e)
        {
            _selectedValue = 4;
        }

        private void RadBtnNum3_CheckedChanged(object sender, EventArgs e)
        {
            _selectedValue = 3;
        }

        private void RadBtnNum2_CheckedChanged(object sender, EventArgs e)
        {
            _selectedValue = 2;
        }

        private void RadBtnNum1_CheckedChanged(object sender, EventArgs e)
        {
            _selectedValue = 1;
        }
    }
}
