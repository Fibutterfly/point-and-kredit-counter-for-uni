using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

// https://material.io/design/color/dark-theme.html#properties
namespace point_counter_for_uni
{
    static class regexer
    {
        static public string uni_id = @"^[A-ZÖÜÓŐÚŰÉÁÍ]{2,6}$";
        static public string Nev = @"^[^0-9]*$";
        static public string NEPTUN = @"^[A-Z0-9]{6}$";
        static public string jelszó = @"^.{6,}$";
        static public string Csak_szam = @"[0-9]";
        static public bool itTextBoxEmpty(List<TextBox> boxes)
        {
            bool rtn = true;
            foreach (TextBox item in boxes)
            {
                if (item.Text == "")
                {
                    MessageBox.Show("Van olyan, amit kikellett volna tölteni, de nem sikerült");
                    item.BackColor = default_colors.ErrorBackGround;
                    item.ForeColor = default_colors.ErrorText;
                    return false;
                }
            }
            return rtn;
        }
        static public void regex_textBox(object sender, CancelEventArgs e)
        {
            TextBox tB = (TextBox)sender;
            Regex re = new Regex(tB.Tag.ToString());
            //e.Cancel = true;
            //MessageBox.Show("Mi a faszom");
            if (re.IsMatch(tB.Text))
            {
                e.Cancel = true;
                if (!String.IsNullOrEmpty(tB.Text))
                {
                    e.Cancel = false;
                    tB.BackColor = default_colors.OkBackGround;
                    tB.ForeColor = default_colors.OkText;
                }
                else
                {
                    tB.BackColor = default_colors.ErrorBackGround;
                    tB.ForeColor = default_colors.ErrorText;
                }
            }
            else
            {
                e.Cancel = true;
                tB.BackColor = default_colors.ErrorBackGround;
                tB.ForeColor = default_colors.ErrorText;
            }
        }
    }
    static class default_colors
    {
        static public Color PrimaryBackGround = ColorTranslator.FromHtml("#263238");
        static public Color PrimaryBackGround_Light = ColorTranslator.FromHtml("#4f5b62");
        static public Color PrimaryBackGround_Dark = ColorTranslator.FromHtml("#000a12");
        static public Color PrimaryText = ColorTranslator.FromHtml("#ffffff");
        static public Color SecondaryBackGround = ColorTranslator.FromHtml("#b71c1c");
        static public Color SecondaryBackGround_light = ColorTranslator.FromHtml("#f05545");
        static public Color SecondaryBackGround_Dark = ColorTranslator.FromHtml("#7f0000");
        static public Color SecondaryText = ColorTranslator.FromHtml("#ffffff");
        static public Color ErrorBackGround = Color.Yellow;
        static public Color ErrorText = Color.Black;
        static public Color OkBackGround = Color.Green;
        static public Color OkText = Color.Black;
    }
    class default_radioButton : RadioButton
    {
        public default_radioButton()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.ForeColor = default_colors.PrimaryText;
        }
    }
    class default_dataGridView : DataGridView
    {
        public default_dataGridView()
        {
            this.BackgroundColor = default_colors.PrimaryBackGround;
            this.Dock = DockStyle.Fill;
            this.ForeColor = default_colors.PrimaryText;
            this.GridColor = default_colors.PrimaryBackGround_Dark;
            this.RowsDefaultCellStyle.BackColor = default_colors.PrimaryBackGround_Light;
            this.DefaultCellStyle.BackColor = default_colors.PrimaryBackGround_Dark;
            this.ColumnHeadersDefaultCellStyle.BackColor = default_colors.PrimaryBackGround_Dark;
            this.RowHeadersDefaultCellStyle.BackColor = default_colors.PrimaryBackGround_Dark;
        }
    }
    class default_checkBox : CheckBox
    {
        public default_checkBox()
        {
            this.ForeColor = default_colors.PrimaryText;
        }
    }
    class default_textBox : TextBox
    {
        public default_textBox()
        {
            this.BackColor = default_colors.SecondaryBackGround;
            this.ForeColor = default_colors.SecondaryText;
            this.BorderStyle = BorderStyle.FixedSingle;
        }
    }
    class default_comboBox : ComboBox
    {
        public default_comboBox()
        {
            this.BackColor = default_colors.SecondaryBackGround;
            this.ForeColor = default_colors.SecondaryText;
            this.FlatStyle = FlatStyle.Flat;
        }
    }
    class second_comboBox : ComboBox
    {
        public second_comboBox()
        {
            this.BackColor = default_colors.PrimaryBackGround;
            this.ForeColor = default_colors.PrimaryText;
            this.FlatStyle = FlatStyle.Flat;
        }
    }
    class default_label : Label
    {
        public default_label()
        {
            this.ForeColor = default_colors.PrimaryText;
            this.FlatStyle = FlatStyle.Flat;
        }
    }
    public class default_form : Form
    {
        public default_form()
        {
            this.BackColor = default_colors.PrimaryBackGround;
        }
    }
    class second_textbox : TextBox
    {
        public second_textbox()
        {
            this.BackColor = default_colors.PrimaryBackGround;
            this.ForeColor = default_colors.PrimaryText;
            this.BorderStyle = BorderStyle.FixedSingle;
        }
    }
    class second_label : Label
    {
        public second_label()
        {
            this.ForeColor = default_colors.SecondaryText;
            this.FlatStyle = FlatStyle.Flat;
        }
    }
    class second_button : Button
    {
        public second_button()
        {
            this.BackColor = default_colors.PrimaryBackGround;
            this.ForeColor = default_colors.PrimaryText;
            this.FlatStyle = FlatStyle.Flat;
        }
    }
    public class second_form : Form
    {
        public second_form()
        {
            this.BackColor = default_colors.SecondaryBackGround;
        }
    }
    class button_default : Button
    {
        public button_default()
        {
            this.BackColor = default_colors.SecondaryBackGround;
            this.ForeColor = default_colors.SecondaryText;
            this.FlatStyle = FlatStyle.Flat;
        }
    }
}
