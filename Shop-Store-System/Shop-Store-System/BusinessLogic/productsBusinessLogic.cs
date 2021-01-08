using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_System.BusinessLogic
{
    class productsBusinessLogic
    {
        private decimal rate;
        private decimal quantity;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

        public decimal Rate
        {
            get => this.rate;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(@"Invalid price!");
                }

                this.rate = value;
            }
        }

        public decimal Quantity
        {
            get => this.quantity;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException(@"Invalid quantity!");
                }

                this.quantity = value;
            }
        }
        public DateTime AddedDate { get; set; }
        public int AddedBy { get; set; }
    }
}
