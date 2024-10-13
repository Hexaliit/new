using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs
{
    public class PersonDto
    {
        public int Id { get; set; }
        [RegularExpression("^[0-9]{10}$", ErrorMessage = "Nationacl Code should be Exactly 10 letters")]
        public string? NationalCode { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public int ProfileId { get; set; }
    }
}
