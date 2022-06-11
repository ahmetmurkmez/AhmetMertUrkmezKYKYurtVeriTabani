using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhmetMertUrkmezKYKYurtVeriTabani.UI
{
    public partial class YemekhaneEkle : Form
    {
        public YemekhaneEkle()
        {
            InitializeComponent();
        }

        private void tamamBTN_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void iptalBTN_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
            {
                if (c.Text == " ")
                {
                    errorProvider1.SetError(c, "Boş bırakılamaz!");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, " ");
                    return true;
                }
            }
            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value == 0)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }
                else
                {
                    errorProvider1.SetError(c, " ");
                    return true;
                }
            }
            return true;
        }
    }
}
