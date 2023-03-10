using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ExcelDataReader;
using SyncDataApp.Data;
using SyncDataApp.Models;

namespace SyncDataApp
{
    class Program
    {
        private static readonly WolfApproveCoreSyncDataContext db = new WolfApproveCoreSyncDataContext();
        static void Main(string[] args)
        {
            try
            {
                System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
                using (var stream = File.Open(@"D:\Program\ImportExcel-mainV2\MSTEmployee.xlsx", FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        int currentTab = 1;
                        do
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                i += 1;
                                if (i == 1)
                                {
                                    continue;
                                }
                                if (currentTab == 1)
                                {

                                    var DepartmentCode = reader.GetValue(0) != null ? reader.GetValue(0).ToString() : "";
                                    var DepartmentTH = reader.GetValue(1) != null ? reader.GetValue(1).ToString() : "";
                                    var DepartmentEN = reader.GetValue(2) != null ? reader.GetValue(2).ToString() : "";
                                    var STATUS = reader.GetValue(3) != null ? reader.GetValue(3).ToString() : "";
                                    var AccountId = reader.GetValue(4) != null ? Convert.ToInt32(reader.GetValue(4).ToString()) : 0;
                                    var CodeCompany = reader.GetValue(5) != null ? reader.GetValue(5).ToString() : "";
                                    var ParentId = reader.GetValue(6) != null ? reader.GetValue(6).ToString() : "";

                                    string[] keywordActive = { "true", "1", "Active" };
                                    string[] keywordNotActive = { "false", "0", "InActive" };
                                    bool statusActive = false;
                                    if (keywordActive.Contains(STATUS))
                                    {
                                        statusActive = true;
                                    }
                                    else if (keywordNotActive.Contains(STATUS))
                                    {
                                        statusActive = false;
                                    }

                                    ManageDepartment(new DepartMentDto()
                                    {
                                        DepartmentCode = DepartmentCode,
                                        NameTh = DepartmentTH,
                                        NameEn = DepartmentEN,
                                        CreatedDate = DateTime.Today,
                                        CreatedBy = "System",
                                        ModifiedDate = DateTime.Today,
                                        ModifiedBy = "System",
                                        IsActive = statusActive,
                                        AccountId = AccountId,
                                        CompanyCode = CodeCompany,
                                        ParenName = ParentId
                                    });


                                }
                                else if (currentTab == 2)
                                {

                                    var PosLvsTH = reader.GetValue(0) != null ? reader.GetValue(0).ToString() : "";
                                    var PosLvsEN = reader.GetValue(1) != null ? reader.GetValue(1).ToString() : "";
                                    var PosLvs = reader.GetValue(2) != null ? Convert.ToDecimal(reader.GetValue(2)) : 0.0m;
                                    var STATUS = reader.GetValue(3) != null ? reader.GetValue(3).ToString() : "";

                                    string[] keywordActive = { "true", "1", "Active" };
                                    string[] keywordNotActive = { "false", "0", "InActive" };
                                    bool statusActive = false;
                                    if (keywordActive.Contains(STATUS))
                                    {
                                        statusActive = true;
                                    }
                                    else if (keywordNotActive.Contains(STATUS))
                                    {
                                        statusActive = false;
                                    }


                                    ManagePositionLavel(new MSTPositionLevel()
                                    {
                                        CreatedDate = DateTime.Today,
                                        CreatedBy = "System",
                                        ModifiedDate = DateTime.Today,
                                        ModifiedBy = "System",
                                        AccountId = 1,
                                        NameEn = PosLvsEN,
                                        NameTh = PosLvsTH,
                                        PositionLevel = PosLvs,
                                        IsActive = statusActive

                                    });
                                }

                                else if (currentTab == 3)
                                {

                                    var WORK_ID = reader.GetValue(0) != null ? reader.GetValue(0).ToString() : "";
                                    var Username = reader.GetValue(1) != null ? reader.GetValue(1).ToString() : "";
                                    var FULL_NAME_TH = reader.GetValue(2) != null ? reader.GetValue(2).ToString() : "";
                                    var FULL_NAME_EN = reader.GetValue(3) != null ? reader.GetValue(3).ToString() : "";
                                    var LOGIN_EMAIL2 = reader.GetValue(4) != null ? reader.GetValue(4).ToString() : "";
                                    var STATUS = reader.GetValue(5) != null ? reader.GetValue(5).ToString() : "";
                                    var PositionNameEN = reader.GetValue(6) != null ? reader.GetValue(6).ToString() : "";
                                    var PositionNameTH = reader.GetValue(7) != null ? reader.GetValue(7).ToString() : "";
                                    var PosLvsEN = reader.GetValue(8) != null ? reader.GetValue(8).ToString() : "";
                                    var DeptCode = reader.GetValue(9) != null ? reader.GetValue(9).ToString() : "";
                                    var Positionid = reader.GetValue(10) != null ? reader.GetValue(10).ToString() : "";
                                    var REPORT_TO = reader.GetValue(11) != null ? reader.GetValue(11).ToString() : "";
                                    var DefaultEN = reader.GetValue(12) != null ? reader.GetValue(12).ToString() : "";
                                    var NumberPhone = reader.GetValue(13) != null ? reader.GetValue(13).ToString() : "";

                                    string[] keywordActive = { "true", "1", "Active" };
                                    string[] keywordNotActive = { "false", "0", "InActive" };
                                    bool statusActive = false;
                                    if (keywordActive.Contains(STATUS))
                                    {
                                        statusActive = true;
                                    }
                                    else if (keywordNotActive.Contains(STATUS))
                                    {
                                        statusActive = false;
                                    }

                                    ManagePositionLavel(new MSTPositionLevel()
                                    {
                                        CreatedDate = DateTime.Today,
                                        CreatedBy = "System",
                                        ModifiedDate = DateTime.Today,
                                        ModifiedBy = "System",
                                        AccountId = 1,
                                        NameEn = PosLvsEN,
                                        NameTh = PosLvsEN,
                                        IsActive = statusActive

                                    });

                                    ManagePosition(new PositionLavelDto()
                                    {
                                        NameEn = PositionNameEN,
                                        NameTh = PositionNameTH,
                                        IsActive = statusActive,
                                        PositionLvsName = PosLvsEN,
                                        CompanyCode = Positionid,
                                        CreatedDate = DateTime.Today,
                                        CreatedBy = "System",
                                        ModifiedDate = DateTime.Today,
                                        ModifiedBy = "System",
                                        AccountId = 1,
                                    });

                                    ManageEmployee(new EmployeeDto()
                                    {

                                        EmployeeCode = WORK_ID,
                                        Username = Username,
                                        NameTh = FULL_NAME_TH,
                                        NameEn = FULL_NAME_TH,
                                        Email = LOGIN_EMAIL2,
                                        IsActive = statusActive,
                                        ReportToEmpCode = REPORT_TO,
                                        PositionNameEn = PositionNameEN,
                                        PositionNameTH = PositionNameTH,
                                        DepartmentCode = DeptCode,
                                        EmpLevel = PosLvsEN,
                                        CreatedDate = DateTime.Today,
                                        CreatedBy = "System",
                                        ModifiedDate = DateTime.Today,
                                        ModifiedBy = "System",
                                        AccountId = 1,
                                        Lang = "EN"

                                    });

                                }

                            }
                            currentTab += 1;
                        } while (
                            reader.NextResult()
                        );

                        // 2. Use the AsDataSet extension method

                        // The result of each spreadsheet is in result.Tables
                    }
                }

                // Close the reader and the stream
                //reader2.Close();
                //stream2.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


        //static void ManageDivition(MSTDivision division)
        //{
        //    var data = db.MSTDivisions.FirstOrDefault(a => a.DivisionCode.Equals(division.DivisionCode));
        //    if (data == null)
        //    {
        //        db.MSTDivisions.Add(division);
        //    }
        //    else
        //    {
        //        data.NameEn = division.NameEn;
        //        data.NameEn = division.NameTh;
        //        data.DivisionCode = division.DivisionCode;
        //        data.CreatedDate = division.CreatedDate;
        //        data.CreatedBy = division.CreatedBy;
        //        data.ModifiedDate = division.ModifiedDate;
        //        data.ModifiedBy = division.ModifiedBy;
        //        data.IsActive = division.IsActive;
        //        data.AccountId = division.AccountId;


        //    }

        //}
        static void ManageDepartment(DepartMentDto departmentDto)
        {
            var data = db.MSTDepartments.FirstOrDefault(a => a.DepartmentCode.Equals(departmentDto.DepartmentCode));
            //var paren = db.MSTDepartments.FirstOrDefault(a => a.DepartmentCode.Contains(departmentDto.ParenName));

            if (data == null)
            {
                db.MSTDepartments.Add(new MSTDepartment()
                {
                    DepartmentCode = departmentDto.DepartmentCode,
                    NameTh = departmentDto.NameTh,
                    NameEn = departmentDto.NameEn,
                    CreatedDate = departmentDto.CreatedDate,
                    CreatedBy = departmentDto.CreatedBy,
                    ModifiedDate = departmentDto.ModifiedDate,
                    ModifiedBy = departmentDto.ModifiedBy,
                    IsActive = departmentDto.IsActive,
                    AccountId = departmentDto.AccountId,
                    CompanyCode = departmentDto.CompanyCode,
                    // ParentId = departmentDto.ParentId
                });
            }
            else
            {

                data.DepartmentCode = departmentDto.DepartmentCode;
                data.NameTh = departmentDto.NameTh;
                data.NameEn = departmentDto.NameEn;
                data.CreatedDate = departmentDto.CreatedDate;
                data.CreatedBy = departmentDto.CreatedBy;
                data.ModifiedDate = departmentDto.ModifiedDate;
                data.ModifiedBy = departmentDto.ModifiedBy;
                data.IsActive = departmentDto.IsActive;
                data.AccountId = departmentDto.AccountId;
                data.CompanyCode = departmentDto.CompanyCode;
                // data.ParentId = departmentDto.ParentId;
            }
            db.SaveChanges();
        }

        static void ManagePositionLavel(MSTPositionLevel positionLevel)
        {
            var data = db.MSTPositionLevels.FirstOrDefault(a => a.NameEn.Equals(positionLevel.NameEn));
            if (data == null)
            {
                db.MSTPositionLevels.Add(positionLevel);
            }
            else
            {
                data.NameEn = positionLevel.NameEn;
                data.NameTh = positionLevel.NameTh;
                data.PositionLevel = positionLevel.PositionLevel;
                data.IsActive = positionLevel.IsActive;
                data.CreatedDate = positionLevel.CreatedDate;
                data.CreatedBy = positionLevel.CreatedBy;
                data.ModifiedDate = positionLevel.ModifiedDate;
                data.ModifiedBy = positionLevel.ModifiedBy;
                data.AccountId = positionLevel.AccountId;
            }
            db.SaveChanges();

        }

        static void ManagePosition(PositionLavelDto positionDto)
        {

            var data = db.MSTPositions.FirstOrDefault(a => a.NameEn.Equals(positionDto.NameEn));
            var positionLvs = db.MSTPositionLevels.FirstOrDefault(a => a.NameEn.Contains(positionDto.PositionLvsName));



            if (data == null)
            {
                db.MSTPositions.Add(new MSTPosition()
                {
                    NameEn = positionDto.NameEn,
                    NameTh = positionDto.NameTh,
                    PositionLevelId = positionLvs.PositionLevelId,
                    IsActive = positionDto.IsActive,
                    CreatedDate = positionDto.CreatedDate,
                    CreatedBy = positionDto.CreatedBy,
                    ModifiedDate = positionDto.ModifiedDate,
                    ModifiedBy = positionDto.ModifiedBy,
                    AccountId = positionDto.AccountId,
                    CompanyCode = positionDto.CompanyCode,

                });


            }
            else
            {
                data.NameEn = positionDto.NameEn;
                data.NameTh = positionDto.NameTh;
                data.PositionLevelId = positionLvs.PositionLevelId;
                data.IsActive = positionDto.IsActive;
                data.CreatedDate = positionDto.CreatedDate;
                data.CreatedBy = positionDto.CreatedBy;
                data.ModifiedDate = positionDto.ModifiedDate;
                data.ModifiedBy = positionDto.ModifiedBy;
                data.AccountId = positionDto.AccountId;
                data.CompanyCode = positionDto.CompanyCode;

            }
            db.SaveChanges();
        }

        static void ManageEmployee(EmployeeDto employeeDto)
        {
            var data = db.MSTEmployees.FirstOrDefault(a => a.EmployeeCode.Equals(employeeDto.EmployeeCode));

            var position = db.MSTPositions.FirstOrDefault(p => p.NameEn.Contains(employeeDto.PositionNameEn));
            var departmentcode = db.MSTDepartments.FirstOrDefault(d => d.DepartmentCode.Contains(employeeDto.DepartmentCode));

            if (data == null)
            {
                db.MSTEmployees.Add(new MSTEmployee
                {
                    EmpLevel = employeeDto.EmpLevel,
                    EmployeeCode = employeeDto.EmployeeCode,
                    Username = employeeDto.Username,
                    NameTh = employeeDto.NameTh,
                    NameEn = employeeDto.NameEn,
                    Email = employeeDto.Email,
                    IsActive = employeeDto.IsActive,
                    ReportToEmpCode = employeeDto.ReportToEmpCode,
                    PositionId = position.PositionId,
                    DepartmentId = departmentcode.DepartmentId,
                    CreatedDate = DateTime.Today,
                    CreatedBy = "System",
                    ModifiedDate = DateTime.Today,
                    ModifiedBy = "System",
                    AccountId = 1,
                    Lang = "EN"
                }); 
            }
            else
            {

                data.EmpLevel = employeeDto.EmpLevel;
                data.EmployeeCode = employeeDto.EmployeeCode;
                data.Username = employeeDto.Username;
                data.NameTh = employeeDto.NameTh;
                data.NameEn = employeeDto.NameEn;
                data.Email = employeeDto.Email;
                data.IsActive = employeeDto.IsActive;
                data.ReportToEmpCode = employeeDto.ReportToEmpCode;
                data.PositionId = position.PositionId;
                data.DepartmentId = departmentcode.DepartmentId;
                data.CreatedDate = DateTime.Today;
                data.CreatedBy = "System";
                data.ModifiedDate = DateTime.Today;
                data.ModifiedBy = "System";
                data.AccountId = 1;
                data.Lang = "EN";

            }
            db.SaveChanges();


        }
    }
}
