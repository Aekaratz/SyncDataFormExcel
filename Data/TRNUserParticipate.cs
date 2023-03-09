using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.Data
{
    public partial class TRNUserParticipate
    {
        public int UPID { get; set; }
        public string DocumentNo { get; set; }
        public int? UserParticipateId { get; set; }
        public string UserParticipateName { get; set; }
        public string StatusName { get; set; }
        public string ActionName { get; set; }
        public bool? IsProcess { get; set; }
    }
}
