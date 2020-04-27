using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace point_counter_for_uni
{
    public partial class Form1 : default_form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            but_BE.Click += But_BE_Click;
            but_REG.Click += But_REG_Click;
        }

        private void But_REG_Click(object sender, EventArgs e)
        {
            Form_reg reg = new Form_reg();
            reg.ShowDialog();
        }

        private void But_BE_Click(object sender, EventArgs e)
        {
            
        }
    }
}
