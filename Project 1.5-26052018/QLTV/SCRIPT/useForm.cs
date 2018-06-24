using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTV.SCRIPT
{
    class useForm
    {
        private static useForm instance;

        internal static useForm Instance
        {
            get
            {
                if (instance == null) instance = new useForm(); return SCRIPT.useForm.instance;
            }

            private set
            {
                SCRIPT.useForm.instance = value;
            }
        }

        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        // Tránh việc gõ chữ vào text box ID
        public void messageShow(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Bạn có thật sự muốn thoát không?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Tránh việc gõ số vào textbox Họ tên
        private void chu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || (e.KeyChar == 8));
        }

        // Show message box cho form
        private void Close()
        {
            throw new NotImplementedException();
        }

        public bool checkNull(Control control)
        {
            if (control is TextBox)
            {
                TextBox tb = (TextBox)control;
                if (tb.Text == "")
                {
                    return true;
                }
            }

            if (control is ComboBox)
            {
                ComboBox cb = (ComboBox)control;
                if (cb.Text == "")
                {
                    return true;
                }

            }
            return false;
        }

        public void Focus(Control control)
        {
            if(control is TextBox)
            {
                TextBox tb = (TextBox)control;
                if (tb.Text == "")
                {
                    tb.Focus();
                }
            }

            if(control is ComboBox)
            {
                ComboBox cb = (ComboBox)control;
                if (cb.Text == "")
                {
                    cb.Focus();
                }             
            }
        }


        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }

                //if (control is RadioButton)
                //{
                //    RadioButton radioButton = (RadioButton)control;
                //    radioButton.Checked = false;
                //}
                if (control is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    dateTimePicker.ResetText();
                }

                if (control is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    pictureBox.Hide();
                }
            }
        }

        public void checkID(bool ado,Label lb, TextBox tb,PictureBox Warning, PictureBox Ss)
        {
            if (ado==true)
            {
                lb.ForeColor = Color.Red;
                lb.Text = "ID này đã tồn tại!!";
                lb.Show();
                Warning.Show();
                Ss.Hide();
            }
            else
            {
                lb.ForeColor = Color.Green;
                lb.Text = "ID phù hợp!!";
                lb.Show();
                Warning.Hide();
                Ss.Show();
            }

            if (tb.Text == "")
            {
                lb.ForeColor = Color.Red;
                lb.Text = "Không được để trống ID";
                lb.Show();
                Ss.Hide();
                Warning.Show();
            }
        }
    }
}
