using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    //class CompanyClientSetup
    //{
    //}
    public partial class CompanyClientSetup
    {
        public string CmpnyClintCode { get; set; }
        public string CmpnyClintName { get; set; }
        public string CmpnyAddres { get; set; }
        public string CmpnyAddres1 { get; set; }
        public string CmpnyAddres2 { get; set; }
        public string CmpnyContNo { get; set; }
        public DateTime? MakerDatetime { get; set; }
        public string MakerId { get; set; }
        public string MakerwrkstId { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public string UpdateId { get; set; }
        public string UpdatewrkstId { get; set; }
        public string OldClientId { get; set; }
    }

    public partial class CompanyClientSetupDTO
    {
        public string CmpnyClintCode { get; set; }
        public string CmpnyClintName { get; set; }
        public string CmpnyAddres { get; set; }       
        public string CmpnyContNo { get; set; }
    }
}
