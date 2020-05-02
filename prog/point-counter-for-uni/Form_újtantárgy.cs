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
    public partial class Form_újtantárgy : second_form
    {
        private string Year;
        private string Semester;
        List<TextBox> validating_textboxes = new List<TextBox>();
        List<TextBox> validating_textboxes_pt = new List<TextBox>();
        List<add_max> add_Maxes = new List<add_max>();
        public Form_újtantárgy(string year, string semester)
        {

            InitializeComponent();
            but_ok_init();
            but_mégse_init();
            but_addtype.Click += But_addtype_Click;
            tB_tárgykód_init();
            tB_tárgynév_init();
            tB_kettes_init();
            tB_három_init();
            tB_négy_init();
            tB_öt_init();
            tB_max_init();
            tB_min_init();
            init_variables(year, semester);
            cB_egyetem_init();
            cB_aláírás_init();
            cB_típus_init();
            addmaxBindingSource.DataSource = add_Maxes;
        }

        private void But_addtype_Click(object sender, EventArgs e)
        {
            if (!regexer.itTextBoxEmpty(validating_textboxes_pt))
            {
                return;
            }

            add_max temp = new add_max(cB_típus.SelectedItem, tB_max.Text,tB_min.Text);
            addmaxBindingSource.Add(temp);
        }

        private void but_ok_init()
        {
            but_ok.Click += But_ok_Click;
            but_ok.CausesValidation = true;
        }

        private void cB_típus_init()
        {
            cB_típus.DataSource = databaseHandler.GetPoint_Types();
            cB_típus.DisplayMember = "PT_name";
            cB_típus.ValueMember = "PT_SK";
        }

        private void cB_aláírás_init()
        {
            List<alairas> data = new List<alairas>();
            alairas hamis = new alairas()
            {
                Text = "Nem aláírásos",
                Value = false
            };
            data.Add(hamis);
            alairas igaz = new alairas()
            {
                Text = "Aláírásos",
                Value = true
            };
            data.Add(igaz);
            cB_aláírás.DataSource = data;
            cB_aláírás.ValueMember = "Value";
            cB_aláírás.DisplayMember = "Text";
        }

        private void cB_egyetem_init()
        {
            cB_egyetem.DataSource = databaseHandler.getUnisByNEPTUN();
        }

        private void init_variables(string year, string semester)
        {
            Year = year;
            Semester = semester;
        }

        private void tB_min_init()
        {
            tB_min.Validating += regexer.regex_textBox;
            tB_min.CausesValidation = false;
            tB_min.Tag = regexer.Csak_szam;
            validating_textboxes_pt.Add(tB_min);
            tB_min.Text = "0";
        }

        private void tB_max_init()
        {
            tB_max.Tag = regexer.Csak_szam;
            tB_max.CausesValidation = false;
            tB_max.Validating += regexer.regex_textBox;
            validating_textboxes_pt.Add(tB_max);
            tB_min.Text = "100";
        }

        private void tB_öt_init()
        {
            tB_öt.Validating += regexer.regex_textBox;
            tB_öt.CausesValidation = false;
            tB_öt.Tag = regexer.Csak_szam;
            validating_textboxes.Add(tB_öt);
        }

        private void tB_négy_init()
        {
            tB_négy.Tag = regexer.Csak_szam;
            tB_négy.CausesValidation = false;
            tB_négy.Validating += regexer.regex_textBox;
            validating_textboxes.Add(tB_négy);
        }

        private void tB_három_init()
        {
            tb_három.Tag = regexer.Csak_szam;
            tb_három.CausesValidation = false;
            tb_három.Validating += regexer.regex_textBox;
            validating_textboxes.Add(tb_három);
        }

        private void tB_kettes_init()
        {
            tB_kettes.Tag = regexer.Csak_szam;
            tB_kettes.CausesValidation = false;
            tB_kettes.Validating += regexer.regex_textBox;
            validating_textboxes.Add(tB_kettes);
        }

        private void tB_tárgynév_init()
        {
            tB_tárgynév.Tag = regexer.Nev;
            tB_tárgynév.CausesValidation = false;
            tB_tárgynév.Validating += regexer.regex_textBox;
            validating_textboxes.Add(tB_tárgynév);
        }

        private void tB_tárgykód_init()
        {
            tB_tárgykód.Tag = regexer.Nev;
            tB_tárgykód.CausesValidation = false;
            tB_tárgykód.Validating += regexer.regex_textBox;
            validating_textboxes.Add(tB_tárgykód);
        }

        private void but_mégse_init()
        {
            but_mégse.Click += But_mégse_Click;
            but_mégse.CausesValidation = false;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            this.CausesValidation = false;
        }
        private void But_mégse_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void But_ok_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (!regexer.itTextBoxEmpty(validating_textboxes))
            {
                return;
            }
            MessageBox.Show(Year);
        }
    }
}
