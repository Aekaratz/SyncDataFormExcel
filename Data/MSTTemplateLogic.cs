using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.Data
{
    public partial class MSTTemplateLogic
    {
        public Guid logicid { get; set; }
        public int? TemplateId { get; set; }
        public int? Seq { get; set; }
        public string logictype { get; set; }
        public string jsonvalue { get; set; }
    }
}
