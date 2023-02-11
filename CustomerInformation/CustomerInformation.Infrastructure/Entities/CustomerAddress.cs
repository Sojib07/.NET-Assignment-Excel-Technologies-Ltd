using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInformation.Infrastructure.Entities
{
    public class CustomerAddress : IEntity<int>
    {
        public int Id { get ; set; }
        public string Address { get; set; }
        public Customer Customer { get; set; }
        public int CustomerID { get; set; }
    }
}
