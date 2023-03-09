using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.Data
{
    public partial class TRNReferenceDoc
    {
        public int RefDocID { get; set; }
        public int? MemoID { get; set; }
        public int? MemoRefDocID { get; set; }
        public string DocumentNo { get; set; }
        public int? TemplateId { get; set; }
        public string TemplateName { get; set; }
        public string MemoSubject { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public int? Seq { get; set; }
        public string ShowColumn { get; set; }
        public decimal? Amount { get; set; }
    }
}
