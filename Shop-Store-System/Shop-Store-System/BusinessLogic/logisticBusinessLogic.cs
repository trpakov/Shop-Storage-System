using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Store_System.BusinessLogic
{
    class logisticBusinessLogic
    {
        private string contact;

        public int Id { get; set; }
        public string Empleyee { get; set; }
        public string Contact
        {
            get => this.contact;
            set
            {
                //Валидация на името..
                if (value.Length <= 9)
                {
                    throw new ArgumentException(@"Invalid contact!");
                }

                this.contact = value;
            }
        }

        public string Address { get; set; }
        public string Date { get; set; }
        public DateTime AddedDate { get; set; }
        public int AddedBy { get; set; }
    }
}
