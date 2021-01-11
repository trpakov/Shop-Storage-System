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

        bool Insert(Category insertedCategory);

        bool Update(Category updatedCategory);

        bool Delete(Category deletedCategory);

        DataTable Search(string keywords);
    }
}
