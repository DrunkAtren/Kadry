using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Kadry.Classes
{
    class SQLPracownicy
    {
        public int ID_Pracownika { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Nr_Telefonu { get; set; }
        public string Adres_Zamieszkania { get; set; }
        public decimal Wynagrodzenie { get; set; }
        public string Mail { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        public DataTable Select2()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //writing sql query
                string sql = "SELECT * FROM PRACOWNICY";
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

        public bool Insert2(SQLPracownicy c)
        {
            //Creating default return type and setting it's value to false
            bool isSuccess = false;

            //connect database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO PRACOWNICY (IMIE,NAZWISKO,NR_TELEFONU,ADRES_ZAMIESZKANIA,WYNAGRODZENIE,MAIL) VALUES (@IMIE,@NAZWISKO,@NR_TELEFONU,@ADRES_ZAMIESZKANIA,@WYNAGRODZENIE,@MAIL)";
                //SQL command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameter to add data
                cmd.Parameters.AddWithValue("@IMIE", c.Imie);
                cmd.Parameters.AddWithValue("@NAZWISKO", c.Nazwisko);
                cmd.Parameters.AddWithValue("@NR_TELEFONU", c.Nr_Telefonu);
                cmd.Parameters.AddWithValue("@ADRES_ZAMIESZKANIA", c.Adres_Zamieszkania);
                cmd.Parameters.AddWithValue("@WYNAGRODZENIE", c.Wynagrodzenie);
                cmd.Parameters.AddWithValue("@MAIL", c.Mail);

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

        public bool Update2(SQLPracownicy c)
        {
            //default return type
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //SQL Update
                string sql = "UPDATE PRACOWNICY SET IMIE=@IMIE,NAZWISKO=@NAZWISKO,NR_TELEFONU=@NR_TELEFONU,ADRES_ZAMIESZKANIA=@ADRES_ZAMIESZKANIA,WYNAGRODZENIE=@WYNAGRODZENIE,MAIL=@MAIL WHERE ID_PRACOWNIKA=@ID_PRACOWNIKA";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ID_PRACOWNIKA", c.ID_Pracownika);
                cmd.Parameters.AddWithValue("@IMIE", c.Imie);
                cmd.Parameters.AddWithValue("@NAZWISKO", c.Nazwisko);
                cmd.Parameters.AddWithValue("@NR_TELEFONU", c.Nr_Telefonu);
                cmd.Parameters.AddWithValue("@ADRES_ZAMIESZKANIA", c.Adres_Zamieszkania);
                cmd.Parameters.AddWithValue("@WYNAGRODZENIE", c.Wynagrodzenie);
                cmd.Parameters.AddWithValue("@MAIL", c.Mail);


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
        public bool Delete2(SQLPracownicy c)
        {
            //jp
            bool isSuccess = false;

            // SQL CON
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM PRACOWNICY WHERE ID_PRACOWNIKA=@ID_PRACOWNIKA";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ID_PRACOWNIKA", c.ID_Pracownika);

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
