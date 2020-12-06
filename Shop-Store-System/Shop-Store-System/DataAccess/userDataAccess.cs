using Shop_Store_System.BusinesLogic;
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
    class userDataAccess
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Вземане на данни
        public DataTable Select()
        {
            //Връзка с базата данни
            SqlConnection conn = new SqlConnection(myconnstrng);

            //Задържане на данните в таблица
            DataTable dt = new DataTable();
            try
            {
                //query за вземане на данните от таблицата с потребителите
                String sql = "SELECT * FROM tbl_users";

                //Изпълнение на query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Получаване на данните в адаптер
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Отваряне на връзката
                conn.Open();

                //Попълване на данните в таблицата
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Грешка
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Затваряне на връзката
                conn.Close();
            }
            //Връщане на данните
            return dt;


        }

        //Добавяне на данни
        public bool Insert(userBusinessLogic user)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                String sql = "INSERT INTO table_users (first_name, last_name, email, username, password, contact, address, gender, user_type, added_date, added_by) VALUES (@first_name, @last_name, @email, @username, @password, @contact, @address, @gender, @user_type, @added_date, @added_by)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@first_name", user.FirstName);
                cmd.Parameters.AddWithValue("@last_name", user.LastName);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@contact", user.Contact);
                cmd.Parameters.AddWithValue("@address", user.Address);
                cmd.Parameters.AddWithValue("@gender", user.Gender);
                cmd.Parameters.AddWithValue("@user_type", user.UserType);
                cmd.Parameters.AddWithValue("@added_date", user.AddedDate);
                cmd.Parameters.AddWithValue("@added_by", user.AddedBy);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //Ако query-то е изпълнено ще върне стойност по-голяма от 0 ако не е изпълнено ще върне стойност по малка от 0
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
        public bool Update(userBusinessLogic user)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "UPDATE table_users SET first_name=@first_name, last_name=@last_name, email=@email, username=@username, password=@password, contact=@contact, address=@address, gender=@gender, user_type=@user_type, added_date=@added_date, added_by=@added_by WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@first_name", user.FirstName);
                cmd.Parameters.AddWithValue("@last_name", user.LastName);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@contact", user.Contact);
                cmd.Parameters.AddWithValue("@address", user.Address);
                cmd.Parameters.AddWithValue("@gender", user.Gender);
                cmd.Parameters.AddWithValue("@user_type", user.Username);
                cmd.Parameters.AddWithValue("@added_date", user.AddedDate);
                cmd.Parameters.AddWithValue("@added_by", user.AddedBy);
                cmd.Parameters.AddWithValue("@id", user.Id);

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
        public bool Delete(userBusinessLogic user)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "DELETE FROM table_users WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", user.Id);

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
    }
}
