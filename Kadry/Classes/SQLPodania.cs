﻿using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Kadry.Classes
{
    class SQLPodania
    {
        public int NR_Podania { get; set; }
        public int NR_Oferty { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }
        public string Mail { get; set; }
        public string Wyksztalcenie { get; set; }
        public string Adres_Zamieszkania { get; set; }
        public int Nr_Telefonu { set; get; }
        public string Dodatkowe_Informacje { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public DataTable Select3()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //writing sql query
                string sql = "SELECT * FROM PODANIA";
                //creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL DatAdapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public bool Insert3(SQLPodania c)
        {
            //Creating default return type and setting it's value to false
            bool isSuccess = false;

            //connect database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO PODANIA (NR_OFERTY,IMIE,NAZWISKO,WIEK,MAIL,WYKSZTALCENIE,ADRES_ZAMIESZKANIA,NR_TELEFONU,DODATKOWE_INFORMACJE) VALUES (@NR_OFERTY,@IMIE,@NAZWISKO,@WIEK,@MAIL,@WYKSZTALCENIE,@ADRES_ZAMIESZKANIA,@NR_TELEFONU,@DODATKOWE_INFORMACJE)";
                //SQL command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameter to add data


                cmd.Parameters.AddWithValue("@NR_OFERTY", c.NR_Oferty);
                cmd.Parameters.AddWithValue("@IMIE", c.Imie);
                cmd.Parameters.AddWithValue("@NAZWISKO", c.Nazwisko);
                cmd.Parameters.AddWithValue("@WIEK", c.Wiek);
                cmd.Parameters.AddWithValue("@MAIL", c.Mail);
                cmd.Parameters.AddWithValue("@WYKSZTALCENIE", c.Wyksztalcenie);
                cmd.Parameters.AddWithValue("@ADRES_ZAMIESZKANIA", c.Adres_Zamieszkania);
                cmd.Parameters.AddWithValue("@NR_TELEFONU", c.Nr_Telefonu);
                cmd.Parameters.AddWithValue("@DODATKOWE_INFORMACJE", c.Dodatkowe_Informacje);

                //con open
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //if querry > 0
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public bool Update3(SQLPodania c)
        {
            //default return type
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //SQL Update
                string sql = "UPDATE PODANIA SET NR_OFERTY=@NR_OFERTY,IMIE=@IMIE,NAZWISKO=@NAZWISKO,WIEK=@WIEK,MAIL=@MAIL,WYKSZTALCENIE=@WYKSZTALCENIE,ADRES_ZAMIESZKANIA=@ADRES_ZAMIESZKANIA,NR_TELEFONU=@NR_TELEFONU,DODATKOWE_INFORMACJE=@DODATKOWE_INFORMACJE WHERE NR_PODANIA=@NR_PODANIA";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@NR_PODANIA", c.NR_Podania);
                cmd.Parameters.AddWithValue("@NR_OFERTY", c.NR_Oferty);
                cmd.Parameters.AddWithValue("@IMIE", c.Imie);
                cmd.Parameters.AddWithValue("@NAZWISKO", c.Nazwisko);
                cmd.Parameters.AddWithValue("@WIEK", c.Wiek);
                cmd.Parameters.AddWithValue("@MAIL", c.Mail);
                cmd.Parameters.AddWithValue("@WYKSZTALCENIE", c.Wyksztalcenie);
                cmd.Parameters.AddWithValue("@ADRES_ZAMIESZKANIA", c.Adres_Zamieszkania);
                cmd.Parameters.AddWithValue("@NR_TELEFONU", c.Nr_Telefonu);
                cmd.Parameters.AddWithValue("@DODATKOWE_INFORMACJE", c.Dodatkowe_Informacje);


                //OPEN CON
                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
        public bool Delete3(SQLPodania c)
        {
            //jp
            bool isSuccess = false;

            // SQL CON
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM PODANIA WHERE NR_PODANIA=@NR_PODANIA";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NR_PODANIA", c.NR_Podania);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}
