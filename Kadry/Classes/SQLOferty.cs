using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Desktop.Classes
{
    class SQLOferty
    {

        public int NR_Oferty { get; set; }
        public int? NR_Oddzialu { get; set; }
        public string NazwaOferty { get; set; }
        public string Wymagania { get; set; }
        public string Obowiazki { get; set; }
        public decimal Wynagrodzenie { get; set; }
        public string Oddzial { get; set; }


        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //writing sql query
                string sql = "SELECT * FROM OFERTY";
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


        //Inserting data into database
        public bool Insert(SQLOferty c)
        {
            //Creating default return type and setting it's value to false
            bool isSuccess = false;

            //connect database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO OFERTY (NR_ODDZIAŁU,NAZWA_OFERTY,WYMAGANIA,OBOWIAZKI,WYNAGRODZENIE,ODDZIAŁ) VALUES (@NR_ODDZIAŁU,@NAZWA_OFERTY,@WYMAGANIA,@OBOWIAZKI,@WYNAGRODZENIE,@ODDZIAŁ)";
                //SQL command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameter to add data
                cmd.Parameters.AddWithValue("@NR_ODDZIAŁU", c.NR_Oddzialu);
                cmd.Parameters.AddWithValue("@NAZWA_OFERTY", c.NazwaOferty);
                cmd.Parameters.AddWithValue("@WYMAGANIA", c.Wymagania);
                cmd.Parameters.AddWithValue("@OBOWIAZKI", c.Obowiazki);
                cmd.Parameters.AddWithValue("@WYNAGRODZENIE", c.Wynagrodzenie);
                cmd.Parameters.AddWithValue("@ODDZIAŁ", c.Oddzial);

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



        public bool Update(SQLOferty c)
        {
            //default return type
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //SQL Update
                string sql = "UPDATE OFERTY SET NAZWA_OFERTY=@NAZWA_OFERTY,WYMAGANIA=@WYMAGANIA,OBOWIAZKI=@OBOWIAZKI,WYNAGRODZENIE=@WYNAGRODZENIE,ODDZIAŁ=@ODDZIAŁ WHERE NR_OFERTY=@NR_OFERTY";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@NR_OFERTY", c.NR_Oferty);
                cmd.Parameters.AddWithValue("@NR_ODDZIAŁU", c.NR_Oddzialu);
                cmd.Parameters.AddWithValue("@NAZWA_OFERTY", c.NazwaOferty);
                cmd.Parameters.AddWithValue("@WYMAGANIA", c.Wymagania);
                cmd.Parameters.AddWithValue("@OBOWIAZKI", c.Obowiazki);
                cmd.Parameters.AddWithValue("@WYNAGRODZENIE", c.Wynagrodzenie);
                cmd.Parameters.AddWithValue("@ODDZIAŁ", c.Oddzial);


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
        public bool Delete(SQLOferty c)
        {
            //jp
            bool isSuccess = false;

            // SQL CON
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM OFERTY WHERE NR_OFERTY=@NR_OFERTY";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NR_OFERTY", c.NR_Oferty);

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
