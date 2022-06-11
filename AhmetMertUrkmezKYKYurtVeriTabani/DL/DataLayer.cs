using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AhmetMertUrkmezKYKYurtVeriTabani.DL
{
    public static class DataLayer
    {
        static MySqlConnection conn = new MySqlConnection(
            new MySqlConnectionStringBuilder()
            {
                Server= "127.0.0.1" ,
                Database = "kykyurtveritabani",
                UserID="root",
                Password= "",
            }.ConnectionString

            );
        public static int OgrenciEkle(ogrenciler o)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("ogrenciEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id",o.ogrenciID);
                komut.Parameters.AddWithValue("@tc", o.ogrenciTC);
                komut.Parameters.AddWithValue("@ad", o.ogrencisim);
                komut.Parameters.AddWithValue("@soy", o.ogrencisoyisim);
                komut.Parameters.AddWithValue("@yas", o.ogrenciyas);
                komut.Parameters.AddWithValue("@memleket", o.ogrencimemleket);
                komut.Parameters.AddWithValue("@telefon", o.ogrencitelefon);
                komut.Parameters.AddWithValue("@kan", o.ogrencikangrubu);
                komut.Parameters.AddWithValue("@bakiye", o.ogrenciyemekhanebakiye);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
                
            }
            finally
            {
                if(conn.State!=System.Data.ConnectionState.Closed)
                conn.Close();
            }
        }

        internal static int PersonelEkle(personel p)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("personelEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", p.personelID);
                komut.Parameters.AddWithValue("@ad", p.personelisim);
                komut.Parameters.AddWithValue("@soy", p.personelsoyisim);
                komut.Parameters.AddWithValue("@yas", p.personelyas);
                komut.Parameters.AddWithValue("@maas", p.personelmaas);
                komut.Parameters.AddWithValue("@telefon", p.personeltelefon);
                komut.Parameters.AddWithValue("@cinsiyet", p.personelcinsiyet);
                komut.Parameters.AddWithValue("@vardiye", p.personelvardiye);
                komut.Parameters.AddWithValue("@memleket", p.personelmemleket);
                komut.Parameters.AddWithValue("@mevkii", p.personelmevkii);
                komut.Parameters.AddWithValue("@kat", p.odalar);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int KatinUrunEkle(kantinurunler k)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("kantinurunEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@numara", k.urunnumarasi);
                komut.Parameters.AddWithValue("@isim", k.urunismi);
                komut.Parameters.AddWithValue("@birimfiyat", k.urunbirimfiyat);
                komut.Parameters.AddWithValue("@stokmiktar", k.urunstokmiktar);
            

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int UrunDuzenle(kantinurunler k)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("urunDuzenle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", k.urunnumarasi);
                komut.Parameters.AddWithValue("@isim", k.urunismi);
                komut.Parameters.AddWithValue("@birimfiyat", k.urunbirimfiyat);
                komut.Parameters.AddWithValue("@stokmiktar", k.urunstokmiktar);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int OdaDuzenle(odalar oda)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("odaDuzenle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", oda.odaID);
                komut.Parameters.AddWithValue("@isim", oda.odanumarasi);
                komut.Parameters.AddWithValue("@birimfiyat", oda.odakati);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int OdaSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("odaSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet OdaGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("odaGoster", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("odaGetir", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int OdaEkle(odalar oda)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("odaEkle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", oda.odaID);
                komut.Parameters.AddWithValue("@numara", oda.odanumarasi);
                komut.Parameters.AddWithValue("@kati", oda.odakati);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int UrunSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("urunSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet UrunGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("urunGoster", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("urunGetir", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int PersonelSil(object id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("personelSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int PersonelDuzenle(personel p)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("ogrenciDuzenle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", p.personelID);
                komut.Parameters.AddWithValue("@ad", p.personelisim);
                komut.Parameters.AddWithValue("@soy", p.personelsoyisim);
                komut.Parameters.AddWithValue("@yas", p.personelyas);
                komut.Parameters.AddWithValue("@maas", p.personelmaas);
                komut.Parameters.AddWithValue("@telefon", p.personeltelefon);
                komut.Parameters.AddWithValue("@cinsiyet", p.personelcinsiyet);
                komut.Parameters.AddWithValue("@vardiye", p.personelvardiye);
                komut.Parameters.AddWithValue("@memleket", p.personelmemleket);
                komut.Parameters.AddWithValue("@mevki", p.personelmevkii);
                komut.Parameters.AddWithValue("@katgorev", p.odalar);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int OgrenciSil(string id)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("ogrenciSil", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);
               

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet PersonelGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("personelGoster", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("personelGetir", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static int OgrenciDuzenle(ogrenciler o)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut = new MySqlCommand("ogrenciDuzenle", conn);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", o.ogrenciID);
                komut.Parameters.AddWithValue("@tc", o.ogrenciTC);
                komut.Parameters.AddWithValue("@ad", o.ogrencisim);
                komut.Parameters.AddWithValue("@soy", o.ogrencisoyisim);
                komut.Parameters.AddWithValue("@yas", o.ogrenciyas);
                komut.Parameters.AddWithValue("@memleket", o.ogrencimemleket);
                komut.Parameters.AddWithValue("@telefon", o.ogrencitelefon);
                komut.Parameters.AddWithValue("@kan", o.ogrencikangrubu);
                komut.Parameters.AddWithValue("@bakiye", o.ogrenciyemekhanebakiye);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }

        internal static DataSet OgrenciGetir(string filtre)
        {
            try
            {
                if (conn.State != System.Data.ConnectionState.Open)
                    conn.Open();
                MySqlCommand komut;
                if (string.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("ogrenciGoster", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                   
                }
                else
                {
                    komut = new MySqlCommand("ogrenciGetir", conn);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
               MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (conn.State != System.Data.ConnectionState.Closed)
                    conn.Close();
            }
        }
    }
}
