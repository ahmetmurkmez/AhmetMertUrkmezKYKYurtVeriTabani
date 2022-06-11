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
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        public personel personel { get; set;}
        public bool Guncelleme { get; internal set; }

        private void tamamBTN_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(textisim)) return;
            if (!ErrorControl(textbolum)) return;
            if (!ErrorControl(textcinsiyet)) return;
            if (!ErrorControl(textsoyisim)) return;
            if (!ErrorControl(textmaas)) return;
            if (!ErrorControl(textsehir)) return;
            if (!ErrorControl(textyas)) return;
            DialogResult = DialogResult.OK;

            personel.personelisim = textisim.Text;
            personel.personelsoyisim = textsoyisim.Text;
            personel.personelmemleket = textsehir.Text;
            personel.personelmaas = Convert.ToInt32(textmaas.Text);
            personel.personelyas = Convert.ToInt32(textyas.Text);
            personel.personeltelefon = Convert.ToInt32(texttelefon.Text);
            personel.personelcinsiyet = textcinsiyet.Text;
            personel.personelvardiye = textvardiye.Text;
            personel.personelmevkii = textbolum.Text;


        }

        private void iptalBTN_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
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
