using Shop_Store_System.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_System.Interfaces
{
    interface ICrudProduct
    {
        DataTable Select();

        bool Insert(productsBusinessLogic insertedProduct);

        bool Update(productsBusinessLogic updatedProduct);

        bool Delete(productsBusinessLogic deletedProduct);

        DataTable Search(string keywords);
    }
}
