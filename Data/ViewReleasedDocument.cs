using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.Data
{
    public partial class ViewReleasedDocument
    {
        public int ReleasedDocumentId { get; set; }
        public string DocumentType { get; set; }
        public string DocumentNumber { get; set; }
        public string DocumentName { get; set; }
        public string DARNumber { get; set; }
        public string ReleasedDocumentStatus { get; set; }
        public int MemoId { get; set; }
        public string DocumentNo { get; set; }
        public int? TemplateId { get; set; }
        public string GroupTemplateName { get; set; }
        public string TemplateName { get; set; }
        public string TemplateType { get; set; }
        public int? DepartmentId { get; set; }
        public string DocumentCode { get; set; }
        public bool? IsPublic { get; set; }
        public string ReportLang { get; set; }
        public string TemplateDetail { get; set; }
        public string ToPerson { get; set; }
        public string CcPerson { get; set; }
        public string TemplateSubject { get; set; }
        public string TTextForm { get; set; }
        public string TAdvanceForm { get; set; }
        public bool? AutoApprove { get; set; }
        public string AutoApproveWhen { get; set; }
        public bool? ApproverCanEdit { get; set; }
        public int? CreatorId { get; set; }
        public string CNameTh { get; set; }
        public string CNameEn { get; set; }
        public int? CPositionId { get; set; }
        public string CPositionTh { get; set; }
        public string CPositionEn { get; set; }
        public int? CDepartmentId { get; set; }
        public string CDepartmentTh { get; set; }
        public string CDepartmentEn { get; set; }
        public int? CDivisionId { get; set; }
        public string CDivisionTh { get; set; }
        public string CDivisionEn { get; set; }
        public int? RequesterId { get; set; }
        public string RNameTh { get; set; }
        public string RNameEn { get; set; }
        public int? RPositionId { get; set; }
        public string RPositionTh { get; set; }
        public string RPositionEn { get; set; }
        public int? RDepartmentId { get; set; }
        public string RDepartmentTh { get; set; }
        public string RDepartmentEn { get; set; }
        public int? RDivisionId { get; set; }
        public string RDivisionTh { get; set; }
        public string RDivisionEn { get; set; }
        public string MemoSubject { get; set; }
        public string MTextForm { get; set; }
        public string MAdvancveForm { get; set; }
        public int? StatusId { get; set; }
        public string StatusName { get; set; }
        public int? CurrentApprovalLevel { get; set; }
        public decimal? Amount { get; set; }
        public DateTime? RequestDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string LastActionBy { get; set; }
        public int? LastStatusId { get; set; }
        public string LastStatusName { get; set; }
        public int? PersonWaitingId { get; set; }
        public string PersonWaiting { get; set; }
        public int? AccountId { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int? ProjectID { get; set; }
        public string ProjectName { get; set; }
        public bool IsReaded { get; set; }
        public string TemplateApproveId { get; set; }
        public int? CheckEmpID { get; set; }
        public DateTime? SLAStartDate { get; set; }
        public DateTime? SLACompletedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
    }
}
