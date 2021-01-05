using Shop_Store_System.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_System.Abstract
{
   public abstract class LoginAbstract
    {
        protected string Username { get; set; }
        protected string Password { get; set; }
        protected string UserType { get; set; }

        //Стринг за връзка с базата данни..
        protected string myconnstrng;

        //Виртуален метод за шаблон..
        public virtual bool loginCheck(loginBusinessLogic login)
        {
            bool isSuccess = false;

            try
            {

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

            return isSuccess;
        }

    }
}
