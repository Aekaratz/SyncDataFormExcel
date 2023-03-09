using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.Data
{
    public partial class MSTAuthorizedMenu
    {
        public int AuMenuID { get; set; }
        public string Process { get; set; }
        public string GroupMenu { get; set; }
        public string SubMenu { get; set; }
        public string ItemMenu { get; set; }
        public int? OrderGroup { get; set; }
        public int? OrderSub { get; set; }
        public int? OrderItem { get; set; }
        public int? InternalUrl { get; set; }
        public string Url { get; set; }
        public string RolesID { get; set; }
        public bool? IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
