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
    public partial class KatinUrunEkle : Form
    {
        internal bool Guncelleme;

        public KatinUrunEkle()
        {
            InitializeComponent();
        }

        public kantinurunler kantinurunler { get; set; }
        private void tamamBTN_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(textbirimfiyat)) return;
            if (!ErrorControl(textstokmiktar)) return;
            if (!ErrorControl(textisim)) return;
            
            DialogResult = DialogResult.OK;

            kantinurunler.urunismi = textisim.Text;
            kantinurunler.urunbirimfiyat = Convert.ToInt32(textbirimfiyat.Text);
            kantinurunler.urunstokmiktar = Convert.ToInt32(textstokmiktar.Text);
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
