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
        public Form_újtárgy()
        {
            InitializeComponent();

            subjectchooserBindingSource.DataSource = databaseHandler.GetSubject_Choosers();

            but_nope.Click += But_nope_Click;
            but_újlistaelem_init();
            tB_year_init();
            cB_félév_init();
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
                subjectchooserBindingSource.DataSource = databaseHandler.GetSubject_Choosers();
            }
        }

        private void But_nope_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
