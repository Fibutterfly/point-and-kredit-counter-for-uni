﻿using System;
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
    public partial class Form1 : default_form
    {
        public Form1()
        {
            InitializeComponent();
            tB_NEPTUN.Tag = regexer.NEPTUN;
            tB_PASS.Tag = regexer.jelszó;
            tB_PASS.PasswordChar = '*';
            tB_NEPTUN.Validating += regexer.regex_textBox;
            tB_PASS.Validating += regexer.regex_textBox;
            but_BE.Click += But_BE_Click;
            but_REG_init();

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            AutoValidate = AutoValidate.Disable;
            this.CausesValidation = false;
            base.OnFormClosing(e);
        }
        private void but_REG_init()
        {
            AutoValidate = AutoValidate.Disable;
            but_REG.CausesValidation = true;
            but_REG.Click += But_REG_Click;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

#if DEBUG
            //tB_NEPTUN.Text = "HS3SS4";
            //tB_PASS.Text = "12345678";
            //login();
#endif
        }

        private void But_REG_Click(object sender, EventArgs e)
        {
            Form_reg reg = new Form_reg();
            reg.ShowDialog();
        }
        private void login()
        {
            try
            {
                if (databaseHandler.login(tB_NEPTUN.Text, tB_PASS.Text))
                {
                    user.NEPTUN = tB_NEPTUN.Text;
                    Form_bejelentekzett temp = new Form_bejelentekzett();
                    temp.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Ilyen felhasználó, jelszó páros nincs");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void But_BE_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
