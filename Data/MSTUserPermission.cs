using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.Data
{
    public partial class MSTUserPermission
    {
        public int EmployeeId { get; set; }
        public int RoleId { get; set; }
        public bool? IsCreate { get; set; }
        public bool? IsEdit { get; set; }
        public bool? IsDelete { get; set; }
        public bool? IsView { get; set; }
        public int? Seq { get; set; }
    }
}
