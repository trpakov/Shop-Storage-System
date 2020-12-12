using Shop_Store_System.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop_Store_System.DataAccess
{
    class transactionDataAccess
    {
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

        //Добавяне на транзакция
        public bool InsertTransaction(transactionBusinessLogic transaction, out int transactionID)
        {
            bool isSuccess = false;

            //Задаване на id на транзакцията първоначално на -1
            transactionID = -1;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO table_transactions (type, dea_cust_id, grandTotal, transaction_date, tax, discount, added_by) VALUES (@type, @dea_cust_id, @grandTotal, @transaction_date, @tax, @discount, @added_by); SELECT @@IDENTITY;";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@type", transaction.Type);
                cmd.Parameters.AddWithValue("@dea_cust_id", transaction.DealerCustomerId);
                cmd.Parameters.AddWithValue("@grandTotal", transaction.GrandTotal);
                cmd.Parameters.AddWithValue("@transaction_date", transaction.TransactionDate);
                cmd.Parameters.AddWithValue("@tax", transaction.Tax);
                cmd.Parameters.AddWithValue("@discount", transaction.Discount);
                cmd.Parameters.AddWithValue("@added_by", transaction.AddedBy);

                conn.Open();

                //Връщасе стойността на първия ред и колона след изпълнението
                object executeQuery = cmd.ExecuteScalar();

                if (executeQuery != null)
                {
                    //Вземане на id на транзакцията ако се е усществила правилно
                    transactionID = int.Parse(executeQuery.ToString());
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
