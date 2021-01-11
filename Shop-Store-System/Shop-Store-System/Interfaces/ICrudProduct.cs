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

        bool Insert(Product insertedProduct);

        bool Update(Product updatedProduct);

        bool Delete(Product deletedProduct);

        DataTable Search(string keywords);
    }
}
