using System;
using System.Collections.Generic;

namespace RamosChipanaPC02.DOMAIN.Core.Entities
{
    public partial class AuditCustomer
    {
        public int Id { get; set; }
        public int IdCustomer { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Phone { get; set; }
        public DateTime? ServerDate { get; set; }
    }
}
