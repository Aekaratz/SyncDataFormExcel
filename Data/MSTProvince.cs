using System;
using System.Collections.Generic;

#nullable disable

namespace SyncDataApp.Data
{
    public partial class MSTProvince
    {
        public int? ProvinceID { get; set; }
        public string Provincethai { get; set; }
        public int? DistrictID { get; set; }
        public string Districtthai { get; set; }
        public int? TambonID { get; set; }
        public string Tambonthai { get; set; }
        public int? Postcode { get; set; }
    }
}
