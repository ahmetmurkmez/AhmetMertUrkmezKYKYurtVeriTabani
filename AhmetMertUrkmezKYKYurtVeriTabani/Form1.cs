using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AhmetMertUrkmezKYKYurtVeriTabani.BL;
using AhmetMertUrkmezKYKYurtVeriTabani.UI;

namespace AhmetMertUrkmezKYKYurtVeriTabani
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }
        private void UygulamayiKapat(object sender, EventArgs e)
        {
            Application.Exit();
        }   

        private void Form1_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.OgrenciGetir(toolStripTextBox2.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void clckOgrenciEkle(object sender, EventArgs e)
        {
            
        }

        private void btnOgrenciBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.OgrenciGetir(toolStripTextBox2.Text);
            if (ds != null)
                dataGridView2.DataSource = ds.Tables[0];
        }

        private void btnOgrenciDuzenle_Click(object sender, EventArgs e)
        {   
            DataGridViewRow row = dataGridView2.SelectedRows[0];

            OgrenciEkle ogrenciEkle = new OgrenciEkle()
            {
                Text = "Ogrenci Düzenle",
                Guncelleme= true,
                ogrenciler = new ogrenciler() 
                {  
                    ogrenciTC = Convert.ToDecimal(row.Cells[1].Value.ToString()), 
                    ogrencisim = row.Cells[2].Value.ToString(), 
                    ogrencisoyisim = row.Cells[3].Value.ToString(),
                    ogrenciyas = Convert.ToInt32(row.Cells[4].Value.ToString()),
                    ogrencimemleket = row.Cells[5].Value.ToString(),
                    ogrencitelefon = row.Cells[6].Value.ToString(),
                    ogrencikangrubu = row.Cells[7].Value.ToString(),
                    ogrenciyemekhanebakiye = Convert.ToInt32(row.Cells[8].Value.ToString())
                },
            };

            var sonuc = ogrenciEkle.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OgrenciDuzenle(ogrenciEkle.ogrenciler);
                if (b)
                {
                    row.Cells[1].Value = ogrenciEkle.ogrenciler.ogrenciTC;
                    row.Cells[2].Value = ogrenciEkle.ogrenciler.ogrencisim;
                    row.Cells[3].Value = ogrenciEkle.ogrenciler.ogrencisoyisim;
                    row.Cells[4].Value = ogrenciEkle.ogrenciler.ogrenciyas;
                    row.Cells[5].Value = ogrenciEkle.ogrenciler.ogrencimemleket;
                    row.Cells[6].Value = ogrenciEkle.ogrenciler.ogrencitelefon;
                    row.Cells[7].Value = ogrenciEkle.ogrenciler.ogrencikangrubu;
                    row.Cells[8].Value = ogrenciEkle.ogrenciler.ogrenciyemekhanebakiye;

                }
            }
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            OgrenciEkle ogrenciEkle = new OgrenciEkle()
            {
                Text = "Ogrenci Ekle",
                ogrenciler = new ogrenciler() { ogrenciID = Guid.NewGuid() }
            };
            var sonuc = ogrenciEkle.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OgrenciEkle(ogrenciEkle.ogrenciler);
                if (b)
                {
                    DataSet ds = BLogic.OgrenciGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnOgrenciSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ogrenciID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi Onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OgrenciSil(ogrenciID);
                if (b)
                {
                    if (b)
                    {
                        DataSet ds = BLogic.OgrenciGetir("");
                        if (ds != null)
                            dataGridView1.DataSource = ds.Tables[0];
                    }

                }
            }
        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            PersonelEkle personelEkle = new PersonelEkle()
            {
                Text = "Personel Ekle",
                personel = new personel() { personelID = Guid.NewGuid() }
            };
            var sonuc = personelEkle.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.PersonelEkle(personelEkle.personel);
                if (b)
                {
                    DataSet ds = BLogic.PersonelGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnPersonelBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.PersonelGetir(toolStripTextBox1.Text);
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnPersonelDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];

            PersonelEkle personelEkle = new PersonelEkle()
            {
                Text = "Personel Düzenle",
                Guncelleme = true,
                personel = new personel()
                {
                    personelisim = row.Cells[1].Value.ToString(),
                    personelsoyisim = row.Cells[2].Value.ToString(),
                    personelyas = Convert.ToInt32(row.Cells[3].Value.ToString()),
                    personelmaas = Convert.ToInt32(row.Cells[4].Value.ToString()),
                    personeltelefon = Convert.ToInt32(row.Cells[5].Value.ToString()),
                    personelcinsiyet = row.Cells[6].Value.ToString(),
                    personelvardiye = row.Cells[7].Value.ToString(),
                    personelmemleket =row.Cells[8].Value.ToString(),
                    personelmevkii = row.Cells[9].Value.ToString(),
                   
                },
            };

            var sonuc = personelEkle.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.PersonelDuzenle(personelEkle.personel);
                if (b)
                {
                    row.Cells[1].Value = personelEkle.personel.personelisim;
                    row.Cells[2].Value = personelEkle.personel.personelsoyisim;
                    row.Cells[3].Value = personelEkle.personel.personelyas;
                    row.Cells[4].Value = personelEkle.personel.personelmaas;
                    row.Cells[5].Value = personelEkle.personel.personeltelefon;
                    row.Cells[6].Value = personelEkle.personel.personelcinsiyet;
                    row.Cells[7].Value = personelEkle.personel.personelvardiye;
                    row.Cells[8].Value = personelEkle.personel.personelmemleket;
                    row.Cells[9].Value = personelEkle.personel.personelmevkii;

                }
            }
        }

        private void BtnPersonelSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var personelID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi Onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.PersonelSil(personelID);
                if (b)
                {
                    if (b)
                    {
                        DataSet ds = BLogic.PersonelGetir("");
                        if (ds != null)
                            dataGridView1.DataSource = ds.Tables[0];
                    }

                }
            }
        }

        private void btnKantinUrunEkle_Click(object sender, EventArgs e)
        {
            KatinUrunEkle urunEkle = new KatinUrunEkle()
            {
                Text = "Ürün Ekle",
                kantinurunler = new kantinurunler() { urunnumarasi = Guid.NewGuid() }
            };
            var sonuc = urunEkle.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.KatinUrunEkle(urunEkle.kantinurunler);
                if (b)
                {
                    DataSet ds = BLogic.UrunGetir("");
                    if (ds != null)
                        dataGridView3.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnKantinUrunBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.UrunGetir(toolStripTextBox3.Text);
            if (ds != null)
                dataGridView3.DataSource = ds.Tables[0];
        }

        private void btnKantinUrunDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView3.SelectedRows[0];

            KatinUrunEkle urunEkle = new KatinUrunEkle()
            {
                Text = "Ürün Düzenle",
                Guncelleme = true,
                kantinurunler = new kantinurunler()
                {
                    urunismi = row.Cells[1].Value.ToString(),
                    urunbirimfiyat = Convert.ToInt32(row.Cells[2].Value.ToString()),
                    urunstokmiktar = Convert.ToInt32(row.Cells[3].Value.ToString()),
                },
            };

            var sonuc = urunEkle.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunDuzenle(urunEkle.kantinurunler);
                if (b)
                {
                    row.Cells[1].Value = urunEkle.kantinurunler.urunismi;
                    row.Cells[2].Value = urunEkle.kantinurunler.urunbirimfiyat;
                    row.Cells[3].Value = urunEkle.kantinurunler.urunstokmiktar;

                }
            }
        }

        private void btnKantinUrunSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView3.SelectedRows[0];
            var urunnumarasi = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi Onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.UrunSil(urunnumarasi);
                if (b)
                {
                    if (b)
                    {
                        DataSet ds = BLogic.PersonelGetir("");
                        if (ds != null)
                            dataGridView1.DataSource = ds.Tables[0];
                    }

                }
            }
        }

        private void btnOdaEkle_Click(object sender, EventArgs e)
        {
            odaEkle odaEkle = new odaEkle()
            {
                Text = "Oda Ekle",
                odalar = new odalar() { odaID = Guid.NewGuid() }
            };
            var sonuc = odaEkle.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdaEkle(odaEkle.odalar);
                if (b)
                {
                    DataSet ds = BLogic.UrunGetir("");
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnOdaDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView4.SelectedRows[0];

            odaEkle odaEkle = new odaEkle()
            {
                Text = "Oda Düzenle",
                Guncelleme = true,
                odalar = new odalar()
                {
                    odanumarasi = Convert.ToInt32(row.Cells[1].Value.ToString()),
                    odakati = Convert.ToInt32(row.Cells[2].Value.ToString()),

                },
            };

            var sonuc = odaEkle.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdaDuzenle(odaEkle.odalar);
                if (b)
                {
                    row.Cells[1].Value = odaEkle.odalar.odanumarasi;
                    row.Cells[2].Value = odaEkle.odalar.odakati;

                }
            }
        }

        private void btnOdaBul_Click(object sender, EventArgs e)
        {
            DataSet ds = BLogic.OdaGetir(toolStripTextBox4.Text);
            if (ds != null)
                dataGridView4.DataSource = ds.Tables[0];
        }

        private void btnOdaSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView4.SelectedRows[0];
            var odaID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kayıt silinsin mi?", "Silmeyi Onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.OdaSil(odaID);
                if (b)
                {
                    if (b)
                    {
                        DataSet ds = BLogic.PersonelGetir("");
                        if (ds != null)
                            dataGridView4.DataSource = ds.Tables[0];
                    }

                }
            }
        }
    }
}
 