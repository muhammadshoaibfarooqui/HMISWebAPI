using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    //class DepartmentSetup
    //{
    //}
    public partial class DepartmentSetup
    {
        public string DptCode { get; set; }
        public string DptDescription { get; set; }
        public bool? DptStatus { get; set; }
        public DateTime? MakerDatetime { get; set; }
        public string MakerId { get; set; }
        public string MakerwrkstId { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public string UpdateId { get; set; }
        public string UpdatewrkstId { get; set; }
        public string EbsDptCode { get; set; }
    }

    public partial class DepartmentSetupDTO
    {
        public string DptCode { get; set; }
        public string DptDescription { get; set; }
        public bool? DptStatus { get; set; }
    }
}
