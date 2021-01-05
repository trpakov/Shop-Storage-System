using Shop_Store_System.BusinesLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_System.Interfaces
{
    interface ICrudUser
    {
        DataTable Select();

        bool Insert(userBusinessLogic insertedUser);

        bool Update(userBusinessLogic updatedUser);

        bool Delete(userBusinessLogic deletedUser);

        DataTable Search(string keywords);
    }
}
