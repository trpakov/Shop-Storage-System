using Shop_Store_System.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop_Store_System.Interfaces;

namespace Shop_Store_System.DataAccess
{
    class transactionDetailDataAccess:transactionDetailBusinessLogic,ITransactionDetail
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Добавяне на детайли по транзакцията
        public bool InsertTransactionDetail(transactionDetailBusinessLogic transactionDetail)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                string sql = "INSERT INTO table_transactions_detail (product_id, rate, qty, total, dea_cust_id, added_date, added_by) VALUES (@product_id, @rate, @qty, @total, @dea_cust_id, @added_date, @added_by)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@product_id", transactionDetail.ProductId);
                cmd.Parameters.AddWithValue("@rate", transactionDetail.Rate);
                cmd.Parameters.AddWithValue("@qty", transactionDetail.Quantity);
                cmd.Parameters.AddWithValue("@total", transactionDetail.Total);
                cmd.Parameters.AddWithValue("@dea_cust_id", transactionDetail.DealerCustomerId);
                cmd.Parameters.AddWithValue("@added_date", transactionDetail.AddedDate);
                cmd.Parameters.AddWithValue("@added_by", transactionDetail.AddedBy);

                conn.Open();

                //Дали има засегнат или променен ред ако има е успешно добавянето на данни
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
