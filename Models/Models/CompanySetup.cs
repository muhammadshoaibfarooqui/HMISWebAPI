using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    //class CompanySetup
    //{
    //}

    public partial class CompanySetup
    {
        public string CmpnyCode { get; set; }
        public string CmpnyName { get; set; }
        public string CmpnySlogin { get; set; }
        public string CmpnyLogo { get; set; }
        public string CmpnyAddres { get; set; }
        public string CmpnyAddres1 { get; set; }
        public string CmpnyAddres2 { get; set; }
        public string CmpnyUanNo { get; set; }
        public string CmpnyLandLine { get; set; }
        public string CmpnyFaxNo { get; set; }
        public string CmpnyEmail { get; set; }
        public string CmpnyUrl { get; set; }
        public bool? CmpnyFlag { get; set; }
        public string CmpnyContPerson { get; set; }
        public string CmpnyContDesig { get; set; }
        public string CmpnyContNo { get; set; }
        public DateTime? MakerDatetime { get; set; }
        public string MakerId { get; set; }
        public string MakerwrkstId { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public string UpdateId { get; set; }
        public string UpdatewrkstId { get; set; }
        public bool? CmpnyZakat { get; set; }
        public bool? CmpnyDiscount { get; set; }
        public string CmpnyGlCode { get; set; }
        public string CmpnyOldCId { get; set; }
        public bool? CmpnyStatus { get; set; }
        public string CmpnyPkgRateRef { get; set; }
        public string CmpnyEbsAccNo { get; set; }
    }
}
