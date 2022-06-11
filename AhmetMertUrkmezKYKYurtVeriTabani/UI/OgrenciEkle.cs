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
    public partial class OgrenciEkle : Form
    {
        public OgrenciEkle()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public ogrenciler ogrenciler { get; set; }
        public odalar oda { get; set; }
        public bool Guncelleme { get; set; } = false;
        private void tamamEvent(object sender, EventArgs e)
        {
            if (!ErrorControl(textisim)) return;
            if (!ErrorControl(textTC)) return;
            if (!ErrorControl(textsoyisim)) return;
            if (!ErrorControl(textkangrup)) return;
            if (!ErrorControl(textsehir)) return;
            if (!ErrorControl(textyas)) return;

            ogrenciler.ogrenciTC = Convert.ToDecimal(textTC.Text);
            ogrenciler.ogrencisim = textisim.Text;
            ogrenciler.ogrencisoyisim = textsoyisim.Text;
            ogrenciler.ogrencimemleket = textsehir.Text;
            ogrenciler.ogrencikangrubu = textkangrup.Text;
            ogrenciler.ogrencitelefon = texttelefon.Text;
            ogrenciler.ogrenciyas = Convert.ToInt32(textyas.Text);
            ogrenciler.ogrenciyemekhanebakiye = Convert.ToInt32(textbakiye.Text);


            DialogResult = DialogResult.OK;
            
        }

        private void iptalEvent(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private bool ErrorControl(Control c)
        {
            if(c is TextBox)
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
            if (c is MaskedTextBox)
            {
                if (!((MaskedTextBox)c).MaskFull)
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

        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
            textID.Text = ogrenciler.ogrenciID.ToString();
            if (Guncelleme){
               textTC.Text = Convert.ToString(ogrenciler.ogrenciTC);
                textisim.Text = ogrenciler.ogrencisim;
                textsoyisim.Text = ogrenciler.ogrencisoyisim;
                textsehir.Text = ogrenciler.ogrencimemleket;
                textkangrup.Text = ogrenciler.ogrencikangrubu;
                texttelefon.Text = ogrenciler.ogrencitelefon;
                textyas.Text = Convert.ToString(ogrenciler.ogrenciyas);
                textbakiye.Text = Convert.ToString(ogrenciler.ogrenciyemekhanebakiye);
            }
        }
    }
}
