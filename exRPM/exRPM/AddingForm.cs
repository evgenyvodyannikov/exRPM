using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exRPM
{
    public partial class AddingForm : Form
    {
        public AddingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void AddingForm_Load(object sender, EventArgs e)
        {
            rbMuz.Checked = true;
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            button1.Enabled = false;
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            if (tbFirstName.Text != "" && tbLastName.Text != "")
            { 
                button1.Enabled = true;
            }
        }
    }
}
