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
    class categoriesDataAccess
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Вземане на данните
        public DataTable Select()
        {
            //Създаване на връзка
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                //Създаване на query за вземане на всички данни от базата данни
                string sql = "SELECT * FROM table_categories";

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

        //Създаване на нова категория
        public bool Insert(categoriesBusinessLogic category)
        {
            bool isSucces = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Създаване на query
                string sql = "INSERT INTO table_categories (title, description, added_date, added_by) VALUES (@title, @description, @added_date, @added_by)";

                //Creating SQL Command to pass values in our query
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Passing Values through parameter
                cmd.Parameters.AddWithValue("@title", category.Title);
                cmd.Parameters.AddWithValue("@description", category.Description);
                cmd.Parameters.AddWithValue("@added_date", category.AddedDate);
                cmd.Parameters.AddWithValue("@added_by", category.AddedBy);

                conn.Open();

                //Вземане на колко редове са запълнени
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
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

            return isSucces;
        }

        //Редактиране на данните
        public bool Update(categoriesBusinessLogic category)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE table_categories SET title=@title, description=@description, added_date=@added_date, added_by=@added_by WHERE id=@id";

                //SQL команда за изпълнение на query-то
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@title", category.Title);
                cmd.Parameters.AddWithValue("@description", category.Description);
                cmd.Parameters.AddWithValue("@added_date", category.AddedDate);
                cmd.Parameters.AddWithValue("@added_by", category.AddedBy);
                cmd.Parameters.AddWithValue("@id", category.Id);

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
        public bool Delete(categoriesBusinessLogic category)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM table_categories WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", category.Id);

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
        public DataTable Search(string keywords)
        {
            SqlConnection conn = new SqlConnection(myconnstrng);

            DataTable dt = new DataTable();

            try
            {
                String sql = "SELECT * FROM table_categories WHERE id LIKE '%" + keywords + "%' OR title LIKE '%" + keywords + "%' OR description LIKE '%" + keywords + "%'";

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
