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
                using (var stream = File.Open(@"D:\Program\ImportExcel-mainV2\Employee2.xlsx", FileMode.Open, FileAccess.Read))
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
                                    //var DepartmentId = reader.GetValue(0);
                                    //var DepartmentCode = reader.GetValue(1) != null ? reader.GetValue(1).ToString() : "";
                                    //var NameTh = reader.GetValue(2) != null ? reader.GetValue(2).ToString() : "";
                                    //var NameEn = reader.GetValue(3) != null ? reader.GetValue(3).ToString() : "";
                                    //var CreatedDate = reader.GetValue(4) != null ? Convert.ToDateTime(reader.GetValue(4)) : default(DateTime);
                                    //var CreatedBy = reader.GetValue(5) != null ? reader.GetValue(5).ToString() : "";
                                    //var ModifiedDate = reader.GetValue(6) != null ? Convert.ToDateTime(reader.GetValue(6)) : default(DateTime);
                                    //var ModifiedBy = reader.GetValue(7) != null ? reader.GetValue(7).ToString() : "";
                                    //var IsActive = reader.GetValue(8) != null ? Convert.ToBoolean(reader.GetValue(8)) : false;
                                    //var AccountId = reader.GetValue(9) != null ? Convert.ToInt32(reader.GetValue(9)) : 0;
                                    //var CompanyCode = reader.GetValue(10) != null ? reader.GetValue(10).ToString() : "";
                                    //var ParentId = reader.GetValue(11) != null ? Convert.ToInt32(reader.GetValue(11).ToString()) : 0;


                                    var externalNameTh = reader.GetValue(0) != null ? reader.GetValue(0).ToString() : "";
                                    var externalNameEn = reader.GetValue(1) != null ? reader.GetValue(1).ToString() : "";
                                    var externalCode = reader.GetValue(2) != null ? reader.GetValue(2).ToString() : "";


                                    
                                    ManageDivition(new MSTDivision()
                                    {
                                        DivisionCode = externalCode,
                                        NameTh = externalNameTh,
                                        NameEn = externalNameEn,
                                        CreatedDate = DateTime.Today,
                                        CreatedBy = "Sytem",
                                        ModifiedDate = DateTime.Today,
                                        ModifiedBy = "Sytem",
                                        IsActive = true,
                                        AccountId = 1

                                    });
                                }
                                else if (currentTab == 2)
                                {

                                    //var PositionLevelId = reader.GetValue(0);
                                    //var NameTh = reader.GetValue(1) != null ? reader.GetValue(1).ToString() : "";
                                    //var NameEn = reader.GetValue(2) != null ? reader.GetValue(2).ToString() : "";
                                    //var PositionLevel = reader.GetValue(3) != null ? Convert.ToDecimal(reader.GetValue(3)) : 0.0m;
                                    //var IsActive = reader.GetValue(4) != null ? Convert.ToBoolean(reader.GetValue(4)) : false;
                                    //var CreatedDate = reader.GetValue(5) != null ? Convert.ToDateTime(reader.GetValue(5)) : default(DateTime);
                                    //var CreatedBy = reader.GetValue(6) != null ? reader.GetValue(6).ToString() : "";
                                    //var ModifiedDate = reader.GetValue(7) != null ? Convert.ToDateTime(reader.GetValue(7)) : default(DateTime);
                                    //var ModifiedBy = reader.GetValue(8) != null ? reader.GetValue(8).ToString() : "";
                                    //var AccountId = reader.GetValue(9) != null ? Convert.ToInt32(reader.GetValue(9).ToString()) : 0;

                                    //ManagePositionLavel(new MSTPositionLevel()
                                    //{
                                    //    NameEn = NameEn,
                                    //    NameTh = NameTh,
                                    //    PositionLevel = PositionLevel,
                                    //    IsActive = IsActive,
                                    //    CreatedDate = CreatedDate,
                                    //    CreatedBy = CreatedBy,
                                    //    ModifiedDate = ModifiedDate,
                                    //    ModifiedBy = ModifiedBy

                                    //});


                                    var DepartmentCode = reader.GetValue(0) != null ? reader.GetValue(0).ToString() : "";
                                    var DepartmentTH = reader.GetValue(1) != null ? reader.GetValue(1).ToString() : "";
                                    var DepartmentEN = reader.GetValue(2) != null ? reader.GetValue(2).ToString() : "";
                                    var STATUS = reader.GetValue(3) != null ? reader.GetValue(3).ToString() : "";
                                    var CompanyCode = reader.GetValue(4) != null ? reader.GetValue(4).ToString() : "";

                                    string[] keywordActive = { "true", "1", "Active" };
                                    string[] keywordNotActive = { "false", "0", "InActive" };
                                     bool statusActive=false; 
                                    if (keywordActive.Contains(STATUS))
                                    {
                                        statusActive =true;
                                    }
                                    else if (keywordNotActive.Contains(STATUS))
                                    {
                                        statusActive =false;
                                    }

                                    ManageDepartment(new MSTDepartment()
                                    {
                                        DepartmentCode = DepartmentCode,
                                        NameTh = DepartmentTH,
                                        NameEn = DepartmentEN,
                                        CreatedDate = DateTime.Today,
                                        CreatedBy = "System",
                                        ModifiedDate = DateTime.Today,
                                        ModifiedBy = "System",
                                        IsActive = statusActive,
                                        AccountId = 1,
                                        CompanyCode = CompanyCode,
                                        ParentId = null
                                    });
                                }

                                else if (currentTab == 3)
                                {
                                    var PosLvsTH = reader.GetValue(0) != null ? reader.GetValue(0).ToString() : "";
                                    var PosLvsEN = reader.GetValue(1) != null ? reader.GetValue(1).ToString() : "";
                                    var PositionLevelId = reader.GetValue(2) != null ? Convert.ToDecimal(reader.GetValue(2)) : 0.0m;
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
                                        PositionLevel = PositionLevelId,
                                        IsActive = statusActive

                                    });



                                }

                                else if (currentTab == 4)
                                {
                                    var positionNameTH = reader.GetValue(0) != null ? reader.GetValue(0).ToString() : "";
                                    var positionNameEN = reader.GetValue(1) != null ? reader.GetValue(1).ToString() : "";
                                    var positionLavelId = reader.GetValue(2) != null ? Convert.ToInt32(reader.GetValue(2).ToString()) : 0;
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

                                    ManagePosition(new MSTPosition()
                                    {
                                        NameEn = positionNameEN,
                                        NameTh = positionNameTH,
                                        PositionLevelId = positionLavelId,
                                        IsActive = statusActive,
                                        CreatedDate = DateTime.Today,
                                        CreatedBy = "System",
                                        ModifiedDate = DateTime.Today,
                                        ModifiedBy = "System",
                                        AccountId = 1,

                                    });
                                }

                                else if (currentTab == 5)
                                {
                                    //var EmployeeId = reader.GetValue(0);
                                    //var EmployeeCode = reader.GetValue(1) != null ? reader.GetValue(1).ToString() : "";
                                    //var Username = reader.GetValue(2) != null ? reader.GetValue(2).ToString() : "";
                                    //var NameTh = reader.GetValue(3) != null ? reader.GetValue(3).ToString() : "";
                                    //var NameEn = reader.GetValue(4) != null ? reader.GetValue(4).ToString() : "";
                                    //var Email = reader.GetValue(5) != null ? reader.GetValue(5).ToString() : "";
                                    //var IsActive = reader.GetValue(6) != null ? Convert.ToBoolean(reader.GetValue(6)) : false;
                                    //var PositionId = reader.GetValue(7) != null ? Convert.ToInt32(reader.GetValue(7).ToString()) : 0;
                                    ////var PositionLevelId = reader.GetValue(8) != null ? Convert.ToInt32(reader.GetValue(8).ToString()) : 0;
                                    //var DepartmentId = reader.GetValue(9) != null ? Convert.ToInt32(reader.GetValue(9).ToString()) : 0;
                                    //var ReportToEmpCode = reader.GetValue(10) != null ? reader.GetValue(10).ToString() : "";
                                    //var Lang = reader.GetValue(11) != null ? reader.GetValue(11).ToString() : "";
                                    //var AccountId = reader.GetValue(12) != null ? Convert.ToInt32(reader.GetValue(12).ToString()) : 0;
                                    //var CreatedDate = reader.GetValue(13) != null ? Convert.ToDateTime(reader.GetValue(13)) : default(DateTime);
                                    //var CreatedBy = reader.GetValue(14) != null ? reader.GetValue(14).ToString() : "";
                                    //var ModifiedDate = reader.GetValue(15) != null ? Convert.ToDateTime(reader.GetValue(15)) : default(DateTime);
                                    //var ModifiedBy = reader.GetValue(16) != null ? reader.GetValue(16).ToString() : "";
                                    //var DivisionId = reader.GetValue(17) != null ? Convert.ToInt32(reader.GetValue(17).ToString()) : 0;
                                    //// var CompanyCode = reader.GetValue(18) != null ? reader.GetValue(18).ToString() : "";
                                    ///
                                    var WORK_ID = reader.GetValue(0) != null ? reader.GetValue(0).ToString() : "";
                                    var FULL_NAME_TH = reader.GetValue(1) != null ? reader.GetValue(1).ToString() : "";
                                    var FULL_NAME_EN = reader.GetValue(2) != null ? reader.GetValue(2).ToString() : "";
                                    var LOGIN_EMAIL = reader.GetValue(3) != null ? reader.GetValue(3).ToString() : "";
                                    var STATUS = reader.GetValue(4) != null ? reader.GetValue(4).ToString() : "";
                                    //var PositionNameTH = reader.GetValue(5) != null ? reader.GetValue(5).ToString() : "";
                                    var PositionNameEn = reader.GetValue(5) != null ? reader.GetValue(5).ToString() : "";
                                    var DepartmentCode = reader.GetValue(6) != null ? reader.GetValue(6).ToString() : "";
                                    var REPORT_TO = reader.GetValue(7) != null ? reader.GetValue(7).ToString() : "";
                                    var user = reader.GetValue(3) != null ? reader.GetValue(3).ToString() : "";
                                    //!= null ? Convert.ToInt32(reader.GetValue(7).ToString()) : 0;
                                    // != null ? Convert.ToBoolean(reader.GetValue(4)) : false;


                                    

                                    string[] UserLogin = user.Split(' ', '@');
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



                                    ManageEmployee(new EmployeeDto()
                                        {

                                            EmployeeCode = WORK_ID,
                                            Username = UserLogin[0],
                                            NameTh = FULL_NAME_TH,
                                            NameEn = FULL_NAME_TH,
                                            Email = LOGIN_EMAIL,
                                            IsActive = statusActive,
                                            ReportToEmpCode = REPORT_TO,
                                            PositionNameEn = PositionNameEn,
                                           // PositionNameTH = PositionNameTH,
                                            DepartmentCode = DepartmentCode,
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
        //static string validateStatus(string status)
        //{
        //    string[] keywordActive = { "true", "1", "active" };
        //    string[] keywordNotActive = { "false", "0", "inactive" };

        //    if (keywordActive.Contains(status))
        //    {
        //        return "Active";
        //    }
        //    else if (keywordNotActive.Contains(status))
        //    {
        //        return "InActive";
        //    }
        //    return "Error";
        //}


        static void ManageDivition(MSTDivision division)
        {
            var data = db.MSTDivisions.FirstOrDefault(a => a.DivisionCode.Equals(division.DivisionCode));
            if (data == null)
            {
                db.MSTDivisions.Add(division);
            }
            else
            {
                data.NameEn = division.NameEn;
                data.NameEn = division.NameTh;
                data.DivisionCode = division.DivisionCode;
                data.CreatedDate = division.CreatedDate;
                data.CreatedBy = division.CreatedBy;
                data.ModifiedDate = division.ModifiedDate;
                data.ModifiedBy = division.ModifiedBy;
                data.IsActive = division.IsActive;
                data.AccountId = division.AccountId;


            }

        }
        static void ManageDepartment(MSTDepartment department)
        {
            var data = db.MSTDepartments.FirstOrDefault(a => a.DepartmentCode.Equals(department.DepartmentCode));

            //var datadivitions = db.MSTDivisions.FirstOrDefault(d => d.NameEn.Equals(department.NameEn));
            //var datadivisionid = db.MSTDivisions.FirstOrDefault(i=>i.DivisionId.Equals())

            if (data == null)
            {
                db.MSTDepartments.Add(department);
            }
            else
            {
              
                data.DepartmentCode = department.DepartmentCode;
                data.NameTh = department.NameTh;
                data.NameEn = department.NameEn;
                data.CreatedDate = department.CreatedDate;
                data.CreatedBy = department.CreatedBy;
                data.ModifiedDate = department.ModifiedDate;
                data.ModifiedBy = department.ModifiedBy;
                data.IsActive = department.IsActive;
                data.AccountId = department.AccountId;
                data.CompanyCode = department.CompanyCode;
                data.ParentId = department.ParentId;
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

        static void ManagePosition(MSTPosition mSTPosition)
        {

            var data = db.MSTPositions.FirstOrDefault(a => a.NameEn.Equals(mSTPosition.NameEn));
           

            if (data == null )
            {
                
                db.MSTPositions.Add(mSTPosition);
            }
            else
            {
                data.NameTh = mSTPosition.NameTh;
                data.NameEn = mSTPosition.NameEn;
                data.PositionLevelId = mSTPosition.PositionLevelId;
                data.IsActive = mSTPosition.IsActive;
                data.CreatedBy = mSTPosition.CreatedBy;
                data.ModifiedDate = mSTPosition.ModifiedDate;
                data.ModifiedBy = mSTPosition.ModifiedBy;
                data.AccountId = mSTPosition.AccountId;

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
                    EmpLevel=employeeDto.EmpLevel,
                    EmployeeCode = employeeDto.EmployeeCode,
                    Username = employeeDto.Username,
                    NameTh = employeeDto.NameTh,
                    NameEn = employeeDto.NameEn,
                    Email = employeeDto.Email,
                    IsActive = employeeDto.IsActive,
                    EmployeeLevel = employeeDto.EmployeeLevel,
                    ReportToEmpCode = employeeDto.ReportToEmpCode,
                    PositionId = position.PositionId,
                    DepartmentId = departmentcode.DepartmentId,
                    CreatedDate = DateTime.Today,
                    CreatedBy = "System",
                    ModifiedDate = DateTime.Today,
                    ModifiedBy = "System",
                    AccountId = 1,
                    Lang = "EN"
                }); ;
            }
            else
            {

                data.EmployeeCode = employeeDto.EmployeeCode;
                data.Username = employeeDto.Username;
                data.NameTh = employeeDto.NameTh;
                data.NameEn = employeeDto.NameEn;
                data.Email = employeeDto.Email;
                data.IsActive = employeeDto.IsActive;
                data.DepartmentId = employeeDto.DepartmentId;
                data.ReportToEmpCode = employeeDto.ReportToEmpCode;
                data.Lang = "EN";
                data.AccountId = employeeDto.AccountId;
                data.CreatedDate = employeeDto.CreatedDate;
                data.CreatedBy = employeeDto.CreatedBy;
                data.ModifiedDate = employeeDto.ModifiedDate;
                data.ModifiedBy = employeeDto.ModifiedBy;
                data.DivisionId = employeeDto.DivisionId;
                data.PositionId = position.PositionId;
                data.DepartmentId = departmentcode.DepartmentId;
                data.EmpLevel = employeeDto.EmpLevel;

            }
            db.SaveChanges();


        }
    }
}
