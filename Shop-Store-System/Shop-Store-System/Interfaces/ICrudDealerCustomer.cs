using Shop_Store_System.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_System.Interfaces
{
    interface ICrudDealerCustomer
    {
        DataTable Select();

        bool Insert(dealerandcustomerBusinessLogic insertedDealerCustomer);

        bool Update(dealerandcustomerBusinessLogic updatedDealerCustomer);

        bool Delete(dealerandcustomerBusinessLogic deletedDealerCustomer);

        DataTable Search(string keyword);
    }
}
