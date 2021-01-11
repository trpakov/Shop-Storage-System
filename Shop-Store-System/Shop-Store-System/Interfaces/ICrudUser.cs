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

        bool Insert(User insertedUser);

        bool Update(User updatedUser);

        bool Delete(User deletedUser);

        DataTable Search(string keywords);
    }
}
