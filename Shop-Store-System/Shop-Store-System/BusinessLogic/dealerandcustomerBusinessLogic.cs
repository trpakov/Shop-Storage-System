using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Shop_Store_System.BusinessLogic
{
    class dealerandcustomerBusinessLogic
    {
        private string name;
        private string email;
        public int Id { get; set; }
        public string Type { get; set; }
        
        public string Name
        {
            get => this.name;
            set
            {
                //Валидация на името..
                if (value.Length <= 2)
                {
                    throw new ArgumentException(@"Invalid name!");
                }

                this.name = value;
            }
        }
        public string Email
        {
            get => this.email;
            set
            {
                //Валидация на emaila..
                Regex regex = new Regex(@"^([\w-.]+)@(([[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.)|(([\w-]+.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(]?)$");
                Match match = regex.Match(value);
                if (match.Success)
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentException(@"Invalid email!");
                }
            }
        }
        public string Contact { get; set; }
        public string Address { get; set; }
        public DateTime AddedDate { get; set; }
        public int AddedBy { get; set; }
    }
}
