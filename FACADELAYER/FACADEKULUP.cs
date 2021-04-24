using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITYLAYER;
namespace FACADELAYER
{
    public class FACADEKULUP
    {
        public static int EKLE(ENTITYKULUP deger) //int yapılma sebebi kayıt sayısı döndermesi
        {
            SqlCommand komut = new SqlCommand("KULUPEKLE",SQLBAGLANTISI.Baglanti);
            komut.CommandType = CommandType.StoredProcedure; // prosedürü bu şekilde tanıtıyoruz.

            if (komut.Connection.State!=ConnectionState.Open) //bağlantı kapalı ise
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("KULUPAD",deger.KULUPAD); //Kulup ad ekleme
            return komut.ExecuteNonQuery();
        }
        public static bool SIL(int deger) //bool olma sebebi ıd sildi mi silmedi mi ID için int parametresi
        {
            SqlCommand komut = new SqlCommand("KULUPSIL",SQLBAGLANTISI.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State!=ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("KULUPID",deger);
            return komut.ExecuteNonQuery() > 0; //true anlamı içerir.
        }

        public static bool GUNCELLE(ENTITYKULUP deger) //bool güncellendi mi güncellenmedi mi
        {
            SqlCommand komut = new SqlCommand("KULUPGUNCELLE",SQLBAGLANTISI.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            komut.Parameters.AddWithValue("KULUPAD",deger.KULUPAD);
            komut.Parameters.AddWithValue("KULUPID",deger.KULUPID);
            return komut.ExecuteNonQuery() > 0;
        }

        public static List<ENTITYKULUP> KULUPLISTESI()
        {
            List<ENTITYKULUP> degerler = new List<ENTITYKULUP>();
            SqlCommand komut = new SqlCommand("KULUPLISTESI",SQLBAGLANTISI.Baglanti);
            komut.CommandType = CommandType.StoredProcedure;
            if (komut.Connection.State != ConnectionState.Open)
            {
                komut.Connection.Open();
            }
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ENTITYKULUP ent = new ENTITYKULUP();
                ent.KULUPID = Convert.ToInt32(dr["KULUPID"]);
                ent.KULUPAD = dr["KULUPAD"].ToString();
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
        }
    }
}
