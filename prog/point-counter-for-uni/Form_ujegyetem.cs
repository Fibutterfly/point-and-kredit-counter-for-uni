using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace point_counter_for_uni
{
    public partial class Form_ujegyetem : second_form
    {
        public Form_ujegyetem()
        {
            InitializeComponent();
            tB_name.Validating += regexer.regex_textBox;
            tB_id.Validating += regexer.regex_textBox;
            but_OK.Click += But_OK_Click;
            but_NO.Click += But_NO_Click;
        }

        private void But_NO_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void But_OK_Click(object sender, EventArgs e)
        {

            try
            {
                databaseHandler.RegisterUniversity(tB_id.Text,tB_name.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

        }


        private void Form_ujegyetem_Load(object sender, EventArgs e)
        {
            tB_name.Tag = regexer.Nev;
            tB_id.Tag = regexer.uni_id;
    }
    }
}
