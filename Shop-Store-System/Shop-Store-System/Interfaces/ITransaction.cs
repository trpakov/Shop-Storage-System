using Shop_Store_System.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_System.Interfaces
{
    interface ITransaction
    {
        DataTable DisplayAllTransactions();

        bool InsertTransaction(Transaction insertedTransaction, out int transactionID);

    }
}
