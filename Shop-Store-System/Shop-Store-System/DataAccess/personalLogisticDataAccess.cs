using Shop_Store_System.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_Store_System.Interfaces;

namespace Shop_Store_System.DataAccess
{
    class personalLogisticDataAccess
    {

        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        public DataTable DisplayLogisticByUsername(string username)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM table_logistic WHERE employee='" + username + "'" ;

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }

        public DataTable DisplayLogisticnByDate(string date, string username)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM table_logistic WHERE date='" + date + "' AND employee='" + username + "'";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
    }
}
