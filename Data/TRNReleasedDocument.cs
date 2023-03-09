using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.Data
{
    public partial class TRNReleasedDocument
    {
        public int ReleasedDocumentId { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string DocumentName { get; set; }
        public string DARNumber { get; set; }
        public string ReleasedDocumentStatus { get; set; }
        public int? MemoId { get; set; }
    }
}
