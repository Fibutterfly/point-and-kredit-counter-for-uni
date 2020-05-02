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
    public partial class Form_reg : second_form
    {
        public Form_reg()
        {
            InitializeComponent();
            tB_NEPTUN.Validating += regexer.regex_textBox;
            //but_újegyetem.Click += But_újegyetem_Click;
            tB_Jelszó.Validating += regexer.regex_textBox;
            tb_Jelszó2.Validating += Tb_Jelszó2_Validating;
            chB_mutasd.CheckedChanged += ChB_mutasd_CheckedChanged;
            but_nope.Click += But_nope_Click;
            but_OK.Click += But_OK_Click;
            tB_NÉV.Validating += regexer.regex_textBox;
        }

        private void But_OK_Click(object sender, EventArgs e)
        {
            try
            {
                databaseHandler.Reg(tB_NEPTUN.Text, tB_Jelszó.Text, tB_NÉV.Text);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void But_nope_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ChB_mutasd_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chB = (CheckBox)sender;
            if (chB.Checked)
            {
                tB_Jelszó.PasswordChar = '\0';
                tb_Jelszó2.PasswordChar = '\0';
            }
            else
            {
                tB_Jelszó.PasswordChar = '*';
                tb_Jelszó2.PasswordChar = '*';
            }
        }

        private void Tb_Jelszó2_Validating(object sender, CancelEventArgs e)
        {
            TextBox tB = (TextBox)sender;
            if (tB.Text == tB_Jelszó.Text)
            {
                e.Cancel = false;
                tB.BackColor = default_colors.OkBackGround;
                tB.ForeColor = default_colors.OkText;

            }
            else
            {
                e.Cancel = true;
                tB.BackColor = default_colors.ErrorBackGround;
                tB.ForeColor = default_colors.ErrorText;
            }
        }

        //private void fillUniBox()
        //{
        //    cB_Uni.DataSource = databaseHandler.getUnis();
        //    cB_Uni.DisplayMember = "Name";
        //}
        private void Form_reg_Load(object sender, EventArgs e)
        {
            //fillUniBox();
            tB_NEPTUN.Tag = regexer.NEPTUN;
            tB_Jelszó.Tag = regexer.jelszó;
            tB_Jelszó.PasswordChar = '*';
            tb_Jelszó2.PasswordChar = '*';
            chB_mutasd.CausesValidation = false;
            but_nope.CausesValidation = false;
            tB_NÉV.Tag = regexer.Nev;
        }

        private void But_újegyetem_Click(object sender, EventArgs e)
        {
            Form_ujegyetem temp = new Form_ujegyetem();
            temp.ShowDialog();
            //fillUniBox();
        }
    }
}

