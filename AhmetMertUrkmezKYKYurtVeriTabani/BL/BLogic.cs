using AhmetMertUrkmezKYKYurtVeriTabani.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AhmetMertUrkmezKYKYurtVeriTabani.BL
{
    public static class BLogic
    {
        public static bool OgrenciEkle(ogrenciler o)
        {
            try
            {
                int res = DataLayer.OgrenciEkle(o);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
          
        }

        internal static DataSet OgrenciGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.OgrenciGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                throw ex;
            }
        }

        internal static bool OgrenciDuzenle(ogrenciler o)
        {
            try
            {
                int res = DataLayer.OgrenciDuzenle(o);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool OgrenciSil(string id)
        {
            try
            {
                int res = DataLayer.OgrenciSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool PersonelEkle(personel p)
        {
            try
            {
                int res = DataLayer.PersonelEkle(p);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static DataSet PersonelGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.PersonelGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                throw ex;
            }
        }

        internal static bool PersonelDuzenle(personel p)
        {
            try
            {
                int res = DataLayer.PersonelDuzenle(p);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool PersonelSil(String id)
        {
            try
            {
                int res = DataLayer.PersonelSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool KatinUrunEkle(kantinurunler k)
        {
            try
            {
                int res = DataLayer.KatinUrunEkle(k);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static DataSet UrunGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.UrunGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                throw ex;
            }
        }

        internal static bool UrunDuzenle(kantinurunler k)
        {
            try
            {
                int res = DataLayer.UrunDuzenle(k);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool UrunSil(string id)
        {
            try
            {
                int res = DataLayer.UrunSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool OdaEkle(odalar oda)
        {
            try
            {
                int res = DataLayer.OdaEkle(oda);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static bool OdaDuzenle(odalar oda)
        {
            try
            {
                int res = DataLayer.OdaDuzenle(oda);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }

        internal static DataSet OdaGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.OdaGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                throw ex;
            }
        }

        internal static bool OdaSil(string id)
        {
            try
            {
                int res = DataLayer.OdaSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
                return false;
            }
        }
    }
}
