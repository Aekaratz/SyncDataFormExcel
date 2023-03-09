using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.Data
{
    public partial class TRNUserTransaction
    {
        public int TransactionId { get; set; }
        public int? EmployeeId { get; set; }
        public string Channel { get; set; }
        public string DeviceToken { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? AccessDate { get; set; }
    }
}
