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
    public partial class Form_újpont : second_form
    {
        int Active;
        public Form_újpont(int act)
        {
            Active = act;
            InitializeComponent();
            Load_jegyek(act);
            Load_pont();
            but_no_load();
            but_ok.Click += But_ok_Click;
        }

        private void But_ok_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cB_tpius.SelectedValue.ToString());
            databaseHandler.New_point(int.Parse(tB_pont.Text),Active,(int)cB_tpius.SelectedValue,dateTimePicker1.Value);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void but_no_load()
        {
            but_no.Click += But_no_Click;
            but_no.CausesValidation = false;
        }

        private void But_no_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Load_pont()
        {
            tB_pont.Tag = regexer.Csak_szam;
            tB_pont.Validating += regexer.regex_textBox;
        }

        private void Load_jegyek(int act)
        {
            cB_tpius.DataSource = databaseHandler.getFilteredSummarizedPoints(act);
            cB_tpius.DisplayMember = "Pont_nev";
            cB_tpius.ValueMember = "Pont_id";
        }
    }
}
