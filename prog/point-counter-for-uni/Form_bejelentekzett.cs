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
    public partial class Form_bejelentekzett : default_form
    {
        public Form_bejelentekzett()
        {
            InitializeComponent();
            //cB_egyetem.SelectionChangeCommitted += CB_egyetem_SelectionChangeCommitted;
            tB_név.TextChanged += TB_név_TextChanged;
            cB_jegyek.SelectionChangeCommitted += CB_jegyek_SelectionChangeCommitted;
            cB_egyenlő.Click += CB_egyenlő_Click;
            rB_kisebb.CheckedChanged += RB_kisebb_CheckedChanged;
            cB_év.SelectedValueChanged += CB_év_SelectedValueChanged;
            but_reset.Click += But_reset_Click;
            dgw_point.CellContentClick += Dgw_point_CellContentClick;
            but_újegyetem.Click += But_újegyetem_Click;
            but_újtárgy.Click += But_újtárgy_Click;
        }

        private void But_újtárgy_Click(object sender, EventArgs e)
        {
            Form_újtárgy temp = new Form_újtárgy();
            DialogResult dr = temp.ShowDialog();
            if (dr == DialogResult.OK)
            {
                //MessageBox.Show("siker");
                fillDgw();
            }
        }

        private void But_újegyetem_Click(object sender, EventArgs e)
        {
            Form_újegyetem _Újegyetem = new Form_újegyetem();
            _Újegyetem.ShowDialog();
            DialogResult dr = _Újegyetem.DialogResult;
            if (dr == DialogResult.OK)
            {
                //MessageBox.Show("siker");
                LoadUniComboBox();

                fillDgw();
            }
        }

        private void CB_egyetem_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cB = (ComboBox)sender;
            if(cB.SelectedIndex >= -1)
            {
                fillDgw();
            }
            
        }

        private void Dgw_point_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                DataGridView dgw = (DataGridView)sender;
                //MessageBox.Show(e.RowIndex.ToString());
                summarized ActiveItem = (summarized)dgw.Rows[e.RowIndex].DataBoundItem;
                int id = databaseHandler.getsubxstudfiltered(ActiveItem.Év, ActiveItem.Tárgy_név);
                Form_részletek reszlet = new Form_részletek(id);
                reszlet.Show();
                //MessageBox.Show(asd.Pont.ToString());
            }
        }

        private void But_reset_Click(object sender, EventArgs e)
        {
            LoadUniComboBox();
            LoadJegyComboBox();
            LoadÉvek();
            initBoxes();
            tB_név.Text = "";
            fillDgw();
        }

        private void CB_év_SelectedValueChanged(object sender, EventArgs e)
        {
            fillDgw();
        }

        private void RB_kisebb_CheckedChanged(object sender, EventArgs e)
        {
            fillDgw();
        }

        private void CB_egyenlő_Click(object sender, EventArgs e)
        {
            fillDgw();
        }

        private void CB_jegyek_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillDgw();
        }

        private void TB_név_TextChanged(object sender, EventArgs e)
        {
            fillDgw();
        }

        private void CB_egyetem_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fillDgw();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }
        private void fillDgw()
        {
            //MessageBox.Show(cB_jegyek.SelectedItem.ToString());
            List<summarized> summarizeds = databaseHandler.filteredSummarizedPoints(cB_egyetem.SelectedItem.ToString(), cB_év.SelectedItem.ToString());
            List<summarized> dataset = filterDGW(summarizeds);
            summarizedBindingSource.DataSource = dataset;
            if (dgw_point.Columns.GetColumnCount(DataGridViewElementStates.Displayed) == 6)
            {
                dgw_point.Columns.RemoveAt(5);
            }
            
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn()
            {
                HeaderText = "",
                Text = "Részletek",
                Name = "Gomb",
                UseColumnTextForButtonValue = true
            };
            dgw_point.Columns.Add(btn);
            //dgw_point.DataSource = dataset;
        }

        private List<summarized> filterDGW(List<summarized> summarizeds)
        {
            List<summarized> dataset = new List<summarized>();
            foreach (summarized item in summarizeds)
            {
                string[] helper = tB_név.Text.Split(';');
                bool berakva = false;
                int i = 0;
                while (!berakva && i < helper.Length)
                {
                    bool nev = item.Tárgy_név.ToUpper().Contains(helper[i].ToUpper());
                    bool szam = true;
                    int filter_jegy = int.Parse(cB_jegyek.SelectedItem.ToString());
                    if (cB_egyenlő.Checked)
                    {
                        if (rB_kisebb.Checked)
                        {
                            //MessageBox.Show("Kissebb és egyenlő");
                            szam = item.Jegy <= filter_jegy;
                        }
                        else
                        {
                            szam = item.Jegy >= filter_jegy;
                        }
                    }
                    else
                    {
                        if (rB_kisebb.Checked)
                        {
                            //MessageBox.Show("Kissebbő");

                            szam = item.Jegy < filter_jegy;
                        }
                        else
                        {
                            szam = item.Jegy > filter_jegy;
                        }
                    }

                    if (nev && szam)
                    {
                        berakva = true;
                        dataset.Add(item);
                    }
                    i++;
                }
            }

            return dataset;
        }

        private void Form_bejelentekzett_Load(object sender, EventArgs e)
        {
            LoadUniComboBox();
            LoadJegyComboBox();
            LoadÉvek();
            initBoxes();
            fillDgw();
            dgw_point.AllowUserToAddRows = false;
            cB_egyetem.SelectedIndexChanged += CB_év_SelectedValueChanged;

        }

        private void LoadÉvek()
        {
            List<string> data = new List<string>();
            data.Add("");
            foreach (string item in databaseHandler.getYearsByNeptun())
            {
                data.Add(item);
            }
            cB_év.DataSource = data;
        }

        private void initBoxes()
        {
            rB_nagyobb.Checked = true;
            cB_egyenlő.Checked = true;
        }

        private void LoadJegyComboBox()
        {
            List<string> data = new List<string>();
            for (int i = 1; i <= 5; i++)
            {
                data.Add(i.ToString());
            }
            cB_jegyek.DataSource = data;
        }

        private void LoadUniComboBox()
        {
            List<string> EgyetemSource = new List<string>();
            EgyetemSource.Add("");
            try
            {
                foreach (string item in databaseHandler.getUnisByNEPTUN())
                {
                    EgyetemSource.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cB_egyetem.DataSource = EgyetemSource;
        }
    }
}
