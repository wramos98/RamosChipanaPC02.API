using System;
using System.Collections.Generic;

namespace RamosChipanaPC02.DOMAIN.Core.Entities
{
    public partial class EmployeeReports
    {
        public int ReportId { get; set; }
        public string? ReportName { get; set; }
        public string? ReportNumber { get; set; }
        public string? ReportDescription { get; set; }
    }
}
