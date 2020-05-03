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
    public partial class Form_újtárgy : second_form
    {
        List<TextBox> validate_textBoxes = new List<TextBox>();
        int Aktívsor = 0;
        public Form_újtárgy()
        {
            InitializeComponent();

            

            but_nope.Click += But_nope_Click;
            but_újlistaelem_init();
            but_felvétel.Click += But_felvétel_Click;
            tB_year_init();
            cB_félév_init();
            tb_kód.TextChanged += filter_text_change;
            tb_név.TextChanged += filter_text_change;
            sub_fill();
            dgw_subchose.CellClick += Dgw_subchose_CellClick;
        }

        private void Dgw_subchose_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Aktívsor = e.RowIndex;
        }

        private void But_felvétel_Click(object sender, EventArgs e)
        {
            if (!regexer.itTextBoxEmpty(validate_textBoxes))
            {
                return;
            }
            subject_chooser sch = ((List<subject_chooser>)subjectchooserBindingSource.DataSource)[Aktívsor];
            string input_év = $"{tB_year.Text}/{cB_félév.SelectedValue}";
            //MessageBox.Show(sch.Sub_SK.ToString());
            if (sch.Év == input_év)
            {
                //MessageBox.Show("már csak felkéne venni");
                databaseHandler.add_StudxSub(sch.Sub_SK);
                sub_fill();
            }
            else
            {
                //MessageBox.Show(sch.Év + " " + input_év);
                Form_újponttípus tmpp = new Form_újponttípus(sch.Sub_SK);
                DialogResult dr = tmpp.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    databaseHandler.add_StudxSub(sch.Sub_SK);
                    sub_fill();
                }
            }
        }

        private void filter_text_change(object sender, EventArgs e)
        {
            sub_fill();
        }

        private void sub_fill()
        {
            subjectchooserBindingSource.DataSource = databaseHandler.GetSubject_Choosers(tb_kód.Text, tb_név.Text);
        }
        private void but_újlistaelem_init()
        {
            but_újlistaelem.Click += But_újlistaelem_Click;
            but_újlistaelem.CausesValidation = true;
        }

        private void cB_félév_init()
        {
            List<string> félévek = new List<string>();
            for (int i = 1; i <= 2; i++)
            {
                félévek.Add(i.ToString());
            }
            cB_félév.DataSource = félévek;
        }

        private void tB_year_init()
        {
            tB_year.Validating += regexer.regex_textBox;
            tB_year.Tag = regexer.Csak_szam;
            validate_textBoxes.Add(tB_year);
        }

        private void But_újlistaelem_Click(object sender, EventArgs e)
        {
            if (!regexer.itTextBoxEmpty(validate_textBoxes))
            {
                return;
            }
            Form_újtantárgy form_Újtantárgy = new Form_újtantárgy(tB_year.Text,cB_félév.SelectedValue.ToString());
            DialogResult dr = form_Újtantárgy.ShowDialog();
            if (dr == DialogResult.OK)
            {
                sub_fill();
            }
        }

        private void But_nope_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
