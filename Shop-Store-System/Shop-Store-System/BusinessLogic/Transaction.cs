using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_System.BusinessLogic
{
    class Transaction
    {
        private decimal tax;
        private decimal discount;

        public int Id { get; set; }
        public string Type { get; set; }
        public int DealerCustomerId { get; set; }
        public decimal GrandTotal { get; set; }
        public DateTime TransactionDate { get; set; }

        public decimal Tax
        {
            //Валидация на таксите
            get => this.tax;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(@"Invalid tax!");
                }

                this.tax = value;
            }
        }

        public decimal Discount
        {
            //Валидация на отсъпка
            get => this.discount;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(@"Invalid discount!");
                }

                this.discount = value;
            }
        }

        public int AddedBy { get; set; }
        public DataTable TransactionDetails { get; set; }
    }
}
