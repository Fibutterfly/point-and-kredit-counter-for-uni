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
    public partial class Form_újponttípus : second_form
    {
        List<add_max> add_Maxes = new List<add_max>();
        List<TextBox> validating_textboxes_pt = new List<TextBox>();
        int SK;
        public Form_újponttípus(int sk)
        {
            InitializeComponent();
            SK = sk;
            cb_típus_init();
            tB_max_init();
            tB_min_init();
            addmaxBindingSource.DataSource = add_Maxes;
            but_addtype.Click += But_addtype_Click;
            but_nope_init();
            but_ok.Click += But_ok_Click;
        }

        private void But_ok_Click(object sender, EventArgs e)
        {
            databaseHandler.add_maxtype(add_Maxes, SK);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void but_nope_init()
        {
            but_nope.Click += But_nope_Click;
            but_nope.CausesValidation = false;
        }

        private void But_nope_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void tB_min_init()
        {
            tB_min.Validating += regexer.regex_textBox;
            //tB_min.CausesValidation = false;
            tB_min.Tag = regexer.Csak_szam;
            validating_textboxes_pt.Add(tB_min);
            tB_min.Text = "0";
        }

        private void tB_max_init()
        {
            tB_max.Tag = regexer.Csak_szam;
            //tB_max.CausesValidation = false;
            tB_max.Validating += regexer.regex_textBox;
            validating_textboxes_pt.Add(tB_max);
            tB_min.Text = "100";
        }
        private void cb_típus_init()
        {
            cB_típus.DataSource = databaseHandler.GetPoint_Types();
            cB_típus.DisplayMember = "PT_name";
            cB_típus.ValueMember = "PT_SK";
        }
        private void But_addtype_Click(object sender, EventArgs e)
        {
            if (!regexer.itTextBoxEmpty(validating_textboxes_pt))
            {
                return;
            }

            add_max temp = new add_max(cB_típus.SelectedItem, tB_max.Text, tB_min.Text);
            addmaxBindingSource.Add(temp);

        }

    }
}
