using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Models
{
    //class AreaSetupNew
    //{
    //}
    public partial class AreaSetupNew
    {
        public string AreaCode { get; set; }
        public string Description { get; set; }
        public string CityCode { get; set; }
        public DateTime? MakerDatetime { get; set; }
        public string MakerId { get; set; }
        public string MakerwrkstId { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public string UpdateId { get; set; }
        public string UpdatewrkstId { get; set; }
        //public string CITYDESCCRIPTION { get; set; }
    }

    public partial class AreaSetupNewVM
    {
        public string AreaCode { get; set; }
        public string Description { get; set; }
        public string CityName { get; set; }

        //public string CityCode { get; set; }
        //public DateTime? MakerDatetime { get; set; }
        //public string MakerId { get; set; }
        // public string MakerwrkstId { get; set; }
        //public DateTime? UpdateDatetime { get; set; }
        //public string UpdateId { get; set; }
        //public string UpdatewrkstId { get; set; }
        //public string CITYDESCCRIPTION { get; set; }
    }

    public class AreaSetupNewDTO
    {
        public string Description { get; set; }
        public string CityCode { get; set; }
        public DateTime? MakerDatetime { get; set; }
        public string MakerId { get; set; }
        public string MakerwrkstId { get; set; }
        public DateTime? UpdateDatetime { get; set; }
        public string UpdateId { get; set; }
        public string UpdatewrkstId { get; set; }
        //public string CITYDESCCRIPTION { get; set; }
    }  
}
