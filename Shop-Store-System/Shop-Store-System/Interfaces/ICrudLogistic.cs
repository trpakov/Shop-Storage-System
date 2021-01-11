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

        bool Insert(Logistic logistic);

        bool Update(Logistic logistic);

        bool Delete(Logistic logistic);

        DataTable Search(string keywords);

        Product GetProductsForLogistic(string keyword);
    }
}
