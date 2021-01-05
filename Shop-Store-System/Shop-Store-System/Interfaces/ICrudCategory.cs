using Shop_Store_System.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_System.Interfaces
{
    interface ICrudCategory
    {
        DataTable Select();

        bool Insert(categoriesBusinessLogic insertedCategory);

        bool Update(categoriesBusinessLogic updatedCategory);

        bool Delete(categoriesBusinessLogic deletedCategory);

        DataTable Search(string keywords);
    }
}
