using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Kadry.Classes
{
    class SQLStanowiska
    {
        public int NR_Stanowiska { get; set; }
        public int ID_Pracownika { get; set; }
        public int NR_Oddziału { get; set; }
        public string Nazwa_Stanowiska { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public DataTable Select5()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                //writing sql query
                string sql = "SELECT * FROM STANOWISKA";
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
        public bool Insert5(SQLStanowiska c)
        {
            //Creating default return type and setting it's value to false
            bool isSuccess = false;

            //connect database
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO STANOWISKA (ID_Pracownika,NR_Oddziału,NAZWA_STANOWISKA) VALUES (@ID_Pracownika,@NR_Oddziału,@NAZWA_STANOWISKA)";
                //SQL command using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Create parameter to add data
                cmd.Parameters.AddWithValue("@ID_Pracownika", c.ID_Pracownika);
                cmd.Parameters.AddWithValue("@NR_Oddziału", c.NR_Oddziału);
                cmd.Parameters.AddWithValue("@NAZWA_STANOWISKA", c.Nazwa_Stanowiska);


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
        public bool Update5(SQLStanowiska c)
        {
            //default return type
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                //SQL Update
                string sql = "UPDATE STANOWISKA SET ID_Pracownika=@ID_Pracownika,NR_Oddziału=@NR_Oddziału,NAZWA_STANOWISKA=@NAZWA_STANOWISKA WHERE NR_Stanowiska=@NR_Stanowiska";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@NR_Stanowiska", c.NR_Stanowiska);
                cmd.Parameters.AddWithValue("@ID_Pracownika", c.ID_Pracownika);
                cmd.Parameters.AddWithValue("@NR_Oddziału", c.NR_Oddziału);
                cmd.Parameters.AddWithValue("@NAZWA_STANOWISKA", c.Nazwa_Stanowiska);


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
        public bool Delete5(SQLStanowiska c)
        {
            //jp
            bool isSuccess = false;

            // SQL CON
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "DELETE FROM STANOWISKA WHERE NR_Stanowiska=@NR_Stanowiska";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@NR_Stanowiska", c.NR_Stanowiska);

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
