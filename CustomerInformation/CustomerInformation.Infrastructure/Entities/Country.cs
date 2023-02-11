using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerInformation.Infrastructure.Entities
{
    public class Country : IEntity<int>
    {
        public int Id { get ; set ; }
        public string CountryName { get; set; }
    }
}
