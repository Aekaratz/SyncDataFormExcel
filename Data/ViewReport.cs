using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.Data
{
    public partial class ViewReport
    {
        public int? ActionHistory_ActionId { get; set; }
        public int? ActionHistory_MemoId { get; set; }
        public int? ActionHistory_ActorId { get; set; }
        public string ActionHistory_ActorName { get; set; }
        public DateTime? ActionHistory_StartDate { get; set; }
        public string ActionHistory_ActionProcess { get; set; }
        public DateTime? ActionHistory_ActionDate { get; set; }
        public int? ActionHistory_NextApproverID { get; set; }
        public string ActionHistoryNextApproverName { get; set; }
        public string ActionHistory_Comment { get; set; }
        public string ActionHistory_SignPicPath { get; set; }
        public string ActionHistory_ActionStatus { get; set; }
        public int? ActionHistory_SignatureId { get; set; }
        public DateTime? ActionHistory_CreatedDate { get; set; }
        public string ActionHistory_CreatedBy { get; set; }
        public bool? ActionHistory_IsActive { get; set; }
        public int? ActionHistory_AccountId { get; set; }
        public int? AttachFile_AttachId { get; set; }
        public int? AttachFile_ActorId { get; set; }
        public string AttachFile_ActorName { get; set; }
        public DateTime? AttachFile_AttachedDate { get; set; }
        public string AttachFile_AttachFile { get; set; }
        public string AttachFile_FileName { get; set; }
        public string AttachFile_FilePath { get; set; }
        public int? AttachFile_MemoId { get; set; }
        public int? AttachFile_DelegateId { get; set; }
        public DateTime? AttachFile_CreatedDate { get; set; }
        public string AttachFile_CreatedBy { get; set; }
        public DateTime? AttachFile_ModifiedDate { get; set; }
        public string AttachFile_ModifiedBy { get; set; }
        public int? AttachFile_AccountId { get; set; }
        public int Memo_MemoId { get; set; }
        public string Memo_DocumentNo { get; set; }
        public int? Memo_TemplateId { get; set; }
        public string Memo_TemplateName { get; set; }
        public string Memo_TemplateType { get; set; }
        public int? Memo_DepartmentId { get; set; }
        public string Memo_DocumentCode { get; set; }
        public bool? Memo_IsPublic { get; set; }
        public string Memo_ReportLang { get; set; }
        public string Memo_ToPerson { get; set; }
        public string Memo_TemplateDetail { get; set; }
        public string Memo_CcPerson { get; set; }
        public string Memo_TemplateSubject { get; set; }
        public string Memo_TTextForm { get; set; }
        public string Memo_TAdvanceForm { get; set; }
        public bool? Memo_AutoApprove { get; set; }
        public string Memo_AutoApproveWhen { get; set; }
        public bool? Memo_ApproverCanEdit { get; set; }
        public int? Memo_CreatorId { get; set; }
        public string Memo_CNameEn { get; set; }
        public string Memo_CNameTh { get; set; }
        public int? Memo_CPositionId { get; set; }
        public string Memo_CPositionTh { get; set; }
        public string Memo_CPositionEn { get; set; }
        public int? Memo_CDepartmentId { get; set; }
        public string Memo_CDepartmentTh { get; set; }
        public string Memo_CDepartmentEn { get; set; }
        public int? Memo_CDivisionId { get; set; }
        public string Memo_CDivisionEn { get; set; }
        public string Memo_CDivisionTh { get; set; }
        public int? Memo_RequesterId { get; set; }
        public string Memo_RequesterCode { get; set; }
        public string Memo_RNameTh { get; set; }
        public string Memo_RNameEn { get; set; }
        public int? Memo_RPositionId { get; set; }
        public string Memo_RPositionTh { get; set; }
        public string Memo_RPositionEn { get; set; }
        public int? Memo_RDepartmentId { get; set; }
        public string Memo_RDepartmentTh { get; set; }
        public string Memo_RDepartmentEn { get; set; }
        public int? Memo_RDivisionId { get; set; }
        public string Memo_RDivisionTh { get; set; }
        public string Memo_RDivisionEn { get; set; }
        public string Memo_MemoSubject { get; set; }
        public string Memo_MTextForm { get; set; }
        public string Memo_MAdvancveForm { get; set; }
        public int? Memo_StatusId { get; set; }
        public string Memo_StatusName { get; set; }
        public int? Memo_CurrentApprovalLevel { get; set; }
        public decimal? Memo_Amount { get; set; }
        public DateTime? Memo_RequestDate { get; set; }
        public DateTime? Memo_CreatedDate { get; set; }
        public string Memo_CreatedBy { get; set; }
        public DateTime? Memo_ModifiedDate { get; set; }
        public string Memo_ModifiedBy { get; set; }
        public string Memo_LastActionBy { get; set; }
        public int? Memo_LastStatusId { get; set; }
        public string Memo_LastStatusName { get; set; }
        public int? Memo_PersonWaitingId { get; set; }
        public string Memo_PersonWaiting { get; set; }
        public int? Memo_AccountId { get; set; }
        public string Memo_CompanyName { get; set; }
        public int? LineApprove_LineApproveId { get; set; }
        public int? LineApprove_MemoId { get; set; }
        public int? LineApprove_Seq { get; set; }
        public int? LineApprove_EmployeeId { get; set; }
        public string LineApprove_EmployeeCode { get; set; }
        public string LineApprove_NameTh { get; set; }
        public string LineApprove_NameEn { get; set; }
        public string LineApprove_PositionTH { get; set; }
        public string LineApprove_PositionEN { get; set; }
        public int? LineApprove_SignatureId { get; set; }
        public string LineApprove_SignatureTh { get; set; }
        public string LineApprove_SignatureEn { get; set; }
        public bool? LineApprove_IsActive { get; set; }
        public int? LineApprove_AccountId { get; set; }
    }
}
