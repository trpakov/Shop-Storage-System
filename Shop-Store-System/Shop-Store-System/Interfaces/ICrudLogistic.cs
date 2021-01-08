using Shop_Store_System.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_System.Interfaces
{
    interface ICrudLogistic
    {

        DataTable Select();

        bool Insert(logisticBusinessLogic logistic);

        bool Update(logisticBusinessLogic logistic);

        bool Delete(logisticBusinessLogic logistic);

        DataTable Search(string keywords);
    }
}
