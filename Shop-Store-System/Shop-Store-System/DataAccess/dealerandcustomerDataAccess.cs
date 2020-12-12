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

namespace Shop_Store_System.DataAccess
{
    class dealerandcustomerDataAccess
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Вземане на данни
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM table_dealer_customer";

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

        //Вкарване на данни
        public bool Insert(dealerandcustomerBusinessLogic dealerAndCustomer)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            bool isSuccess = false;

            try
            {
                string sql = "INSERT INTO table_dealer_customer (type, name, email, contact, address, added_date, added_by) VALUES (@type, @name, @email, @contact, @address, @added_date, @added_by)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@type", dealerAndCustomer.Type);
                cmd.Parameters.AddWithValue("@name", dealerAndCustomer.Name);
                cmd.Parameters.AddWithValue("@email", dealerAndCustomer.Email);
                cmd.Parameters.AddWithValue("@contact", dealerAndCustomer.Contact);
                cmd.Parameters.AddWithValue("@address", dealerAndCustomer.Address);
                cmd.Parameters.AddWithValue("@added_date", dealerAndCustomer.AddedDate);
                cmd.Parameters.AddWithValue("@added_by", dealerAndCustomer.AddedBy);

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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        //Редактиране на данни
        public bool Update(dealerandcustomerBusinessLogic dealerAndCustomer)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            bool isSuccess = false;

            try
            {
                string sql = "UPDATE table_dealer_customer SET type=@type, name=@name, email=@email, contact=@contact, address=@address, added_date=@added_date, added_by=@added_by WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@type", dealerAndCustomer.Type);
                cmd.Parameters.AddWithValue("@name", dealerAndCustomer.Name);
                cmd.Parameters.AddWithValue("@email", dealerAndCustomer.Email);
                cmd.Parameters.AddWithValue("@contact", dealerAndCustomer.Contact);
                cmd.Parameters.AddWithValue("@address", dealerAndCustomer.Address);
                cmd.Parameters.AddWithValue("@added_date", dealerAndCustomer.AddedDate);
                cmd.Parameters.AddWithValue("@added_by", dealerAndCustomer.AddedBy);
                cmd.Parameters.AddWithValue("@id", dealerAndCustomer.Id);

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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        //Изтриване на данни
        public bool Delete(dealerandcustomerBusinessLogic dealerAndCustomer)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            bool isSuccess = false;

            try
            {
                string sql = "DELETE FROM table_dealer_customer WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", dealerAndCustomer.Id);

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
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        //Търсене на данни
        public DataTable Search(string keyword)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                //Write the Query to Search Dealer or Customer Based in id, type and name
                string sql = "SELECT * FROM table_dealer_customer WHERE id LIKE '%" + keyword + "%' OR type LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";

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

        //Търсене в данните
        public dealerandcustomerBusinessLogic SearchDealerCustomerForTransaction(string keyword)
        {
            dealerandcustomerBusinessLogic dealerCustomer = new dealerandcustomerBusinessLogic();

            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT name, email, contact, address from table_dealer_customer WHERE id LIKE '%" + keyword + "%' OR name LIKE '%" + keyword + "%'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                adapter.Fill(dt);

                //Ако успешно имам намерени данни ние ги запазваме в обекта от business logic 
                if (dt.Rows.Count > 0)
                {
                    dealerCustomer.Name = dt.Rows[0]["name"].ToString();
                    dealerCustomer.Email = dt.Rows[0]["email"].ToString();
                    dealerCustomer.Contact = dt.Rows[0]["contact"].ToString();
                    dealerCustomer.Address = dt.Rows[0]["address"].ToString();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dealerCustomer;
        }

        //Вземане на id-то от името 
        public dealerandcustomerBusinessLogic GetDeaCustIDFromName(string Name)
        {
            dealerandcustomerBusinessLogic dealerCustomer = new dealerandcustomerBusinessLogic();

            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT id FROM table_dealer_customer WHERE name='" + Name + "'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);

                conn.Open();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dealerCustomer.Id = int.Parse(dt.Rows[0]["id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dealerCustomer;
        }

    }
}
