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
    public partial class Form_újegyetem : second_form
    {
        string activeID;
        public Form_újegyetem()
        {
            InitializeComponent();
            default_dataGridView1.DataSource = databaseHandler.GetUniversities();
            default_dataGridView1.CellClick += Default_dataGridView1_CellClick;

            but_addchosen.Click += But_addchosen_Click;
            but_addnewuni.Click += But_addnewuni_Click;
            but_nope.Click += But_nope_Click;
        }

        private void But_nope_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void But_addnewuni_Click(object sender, EventArgs e)
        {
            Form_ujegyetem temp = new Form_ujegyetem();
            DialogResult dr = temp.ShowDialog();
            if (dr == DialogResult.OK)
            {
                default_dataGridView1.DataSource = databaseHandler.GetUniversities();
            }
        }

        private void Default_dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            activeID = default_dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void But_addchosen_Click(object sender, EventArgs e)
        {
            activeID = (activeID == null) ? (default_dataGridView1.Rows[0].Cells[0].Value.ToString()) : (activeID);
            //MessageBox.Show(activeID);

            databaseHandler.addStudxuni(activeID);
            this.DialogResult = DialogResult.OK;

            this.Close();
        }
    }
}
