using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           txtResult.Text= (int.Parse(txtNo1.Text) + int.Parse(txtNo2.Text)).ToString();
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            txtResult.Text = (int.Parse(txtNo1.Text) - int.Parse(txtNo2.Text)).ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            txtResult.Text = (int.Parse(txtNo1.Text) * int.Parse(txtNo2.Text)).ToString();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtResult.Text = (int.Parse(txtNo1.Text) / int.Parse(txtNo2.Text)).ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Form is Loaded");
        }
    }
}
