﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using entitylayer;
using System.Data.SqlClient;
using System.Data;


namespace dataacceslayer
{
    public class dalpersonel
    {
        public static List<entitypersonel> personellistesi()
        {
            List<entitypersonel>degerler =new List<entitypersonel>();
            SqlCommand komut1 = new SqlCommand("select *from TBLBILGI",baglantı.bgl);
            if (komut1.Connection.State != ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr =komut1.ExecuteReader();
            while (dr.Read())
            {
                entitypersonel ent = new entitypersonel() ;
                ent.Id = int.Parse(dr["ID"].ToString());
                ent.Ad = (dr["AD"].ToString());
                ent.Soyad = (dr["SOYAD"].ToString());
                ent.Sehir = (dr["SEHIR"].ToString());
                ent.Gorev = (dr["GOREV"].ToString());
                ent.Maas = short.Parse((dr["MAAS"].ToString()));
                degerler.Add(ent);
              
            }
            dr.Close();
            return degerler;
        }
        public static int personelekle(entitypersonel p)
        {
            SqlCommand komut2 = new SqlCommand("insert into TBLBILGI(AD,SOYAD,GOREV,SEHIR,MAAS)VALUES (@P1,@P2,@P3,@P4,@P5)", baglantı.bgl);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            else
            {
                return -1;
            }
            komut2.Parameters.AddWithValue("@p1", p.Ad);
            komut2.Parameters.AddWithValue("@p2", p.Soyad);
            komut2.Parameters.AddWithValue("@p3", p.Gorev);
            komut2.Parameters.AddWithValue("@p4", p.Sehir);
            komut2.Parameters.AddWithValue("@p5", p.Maas);
            return komut2.ExecuteNonQuery();
            


        }
        public static bool personelsil(int p)
        {
            SqlCommand komut3 =new SqlCommand("delete fROM TBLBILGI where ID=@p1",baglantı.bgl);
            if(komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery() > 0;
        }
        public static bool personelguncelle(entitypersonel ent)
        {
            SqlCommand komut4 = new SqlCommand("update tblbılgı set ad=@p1,@p2=soyad,maas=@p3,SEHIR=@p4,gorev=@p5 where ıd=@p6",baglantı.bgl);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", ent.Ad);
            komut4.Parameters.AddWithValue("@p2", ent.Soyad);
            komut4.Parameters.AddWithValue("@p3", ent.Maas);
            komut4.Parameters.AddWithValue("@p4", ent.Sehir);
            komut4.Parameters.AddWithValue("@p5", ent.Gorev);
            komut4.Parameters.AddWithValue("@p6", ent.Id);
            return komut4.ExecuteNonQuery() > 0;

        }

    }
}
