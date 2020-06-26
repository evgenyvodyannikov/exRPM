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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int i = 0;
        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddingForm adf = new AddingForm();
            if(adf.ShowDialog() == DialogResult.OK)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = adf.tbLastName.Text;
                dataGridView1.Rows[i].Cells[1].Value = adf.tbFirstName.Text;
                if(adf.rbMuz.Checked)
                { dataGridView1.Rows[i].Cells[2].Value = adf.rbMuz.Text; }
                else
                { dataGridView1.Rows[i].Cells[2].Value = adf.rbZen.Text; }
                dataGridView1.Rows[i].Cells[3].Value = adf.comboBox1.SelectedItem.ToString();
                dataGridView1.Rows[i].Cells[4].Value = adf.cbOplata.Checked;
                dataGridView1.Rows[i].Cells[5].Value = adf.cbFoto.Checked;
                dataGridView1.Rows[i].Cells[6].Value = adf.cbPassport.Checked;
                dataGridView1.Rows[i].Cells[7].Value = adf.comboBox2.SelectedItem.ToString();
                i++;
            }
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            i = 0;
        }
    }
}
