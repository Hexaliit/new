using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models
{
    public class Person
    {
        public int Id { get; set; }
        public String? FirstName { get; set; }
        public String? LastName { get; set; }
        public String? NationalCode { get; set; }
        public String? Email { get; set; }
        public String? Phone { get; set; }
        public Profile Profile { get; set; }
        public int ProfileId { get; set; }
    }
}
