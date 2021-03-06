using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    //class CitySetup
    //{
    //}

    public partial class CitySetup
    {
        public string CityCode { get; set; }
        //public string Description { get; set; }

        public string CityDescription { get; set; }
        public DateTime? MakerDatetime { get; set; }
        public string MakerId { get; set; }
        public string MakerwrkstId { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public string UpdateId { get; set; }
        public string UpdatewrkstId { get; set; }
        public bool? Status { get; set; }
    }

    public partial class CitySetupDTO
    {
        public string CityCode { get; set; }
        public string CityDescription { get; set; }
        public bool? Status { get; set; }
    }
}
