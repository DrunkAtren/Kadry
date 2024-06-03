using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Kadry.Classes
{
    class SQLOddzial
    {
        public int NR_Oddziału { get; set; }
        public int NR_Działu { get; set; }
        public string Nazwa { get; set; }
        public string Kierownik { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public DataTable Select4()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //writing sql query
                string sql = "SELECT * FROM ODDZIAŁ";
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
        public bool Insert4(SQLOddzial c)
        {
            //Creating default return type and setting it's value to false
            bool isSuccess = false;

            //connect database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO ODDZIAŁ (NR_DZIAŁU,NAZWA,KIEROWNIK) VALUES (@NR_DZIAŁU,@NAZWA,@KIEROWNIK)";
                //SQL command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameter to add data
                cmd.Parameters.AddWithValue("@NR_DZIAŁU", c.NR_Działu);
                cmd.Parameters.AddWithValue("@NAZWA", c.Nazwa);
                cmd.Parameters.AddWithValue("@KIEROWNIK", c.Kierownik);

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
        public bool Update4(SQLOddzial c)
        {
            //default return type
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //SQL Update
                string sql = "UPDATE ODDZIAŁ SET NR_DZIAŁU=@NR_DZIAŁU,NAZWA=@NAZWA,KIEROWNIK=@KIEROWNIK WHERE NR_ODDZIAŁU=@NR_ODDZIAŁU";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@NR_ODDZIAŁU", c.NR_Oddziału);
                cmd.Parameters.AddWithValue("@NR_DZIAŁU", c.NR_Działu);
                cmd.Parameters.AddWithValue("@NAZWA", c.Nazwa);
                cmd.Parameters.AddWithValue("@KIEROWNIK", c.Kierownik);


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
        public bool Delete4(SQLOddzial c)
        {
            //jp
            bool isSuccess = false;

            // SQL CON
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM ODDZIAŁ WHERE NR_ODDZIAŁU=@NR_ODDZIAŁU";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NR_ODDZIAŁU", c.NR_Oddziału);

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
