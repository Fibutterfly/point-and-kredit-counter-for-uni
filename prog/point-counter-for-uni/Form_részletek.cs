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
    public partial class Form_részletek : default_form
    {
        private int act;
        public Form_részletek(int StudxSub_SK)
        {
            InitializeComponent();
            act = StudxSub_SK;
            Load_summared_dgw(StudxSub_SK);
            dgw_összesített.CellClick += Dgw_összesített_CellClick;
            dgw_részletek.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            but_új.Click += But_új_Click;
            but_mód.Click += But_mód_Click;
            but_del.Click += But_del_Click;
            //MessageBox.Show(StudxSub_SK.ToString());
        }

        private void But_del_Click(object sender, EventArgs e)
        {
            
            if (dgw_részletek.SelectedRows.Count > 0)
            {
                dgw_részletek.Rows.Remove(dgw_részletek.SelectedRows[0]);
            }
        }

        private void But_mód_Click(object sender, EventArgs e)
        {
            databaseHandler.Save();
            Load_summared_dgw(act);
        }

        private void But_új_Click(object sender, EventArgs e)
        {
            Form_újpont _Újpont = new Form_újpont(act);
            DialogResult a = _Újpont.ShowDialog();
            if (a == DialogResult.OK)
            {
                Load_summared_dgw(act);
            }
        }

        private void Dgw_összesített_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dgw = (DataGridView)sender;
                sum_by_types act = (sum_by_types)dgw.Rows[e.RowIndex].DataBoundItem;

                pointBindingSource.DataSource = databaseHandler.getPointsBySummarize(act.Pont_id);

            }
            //MessageBox.Show(act.Pont_nev);
        }

        private void Load_summared_dgw(int StudxSub_SK)
        {
            dgw_összesített.AllowUserToAddRows = false;
            
            sumbytypesBindingSource.DataSource = databaseHandler.getFilteredSummarizedPoints(StudxSub_SK);
            dgw_összesített.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgw_összesített.SelectionMode = DataGridViewSelectionMode.RowHeaderSelect;
            dgw_összesített.MultiSelect = false;
        }

        private void Form_részletek_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dgw_részletek.NewRowIndex.ToString());
            databaseHandler.Save();
        }
    }
}
