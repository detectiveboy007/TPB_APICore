using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web_TPB_API.Models
{
    [Table("V_ClosingM")]
    public class V_ClosingM
    {
        [Key]
        public int Auto_Id { get; set; }
        public string Business_Unit { get; set; }
        public decimal Motor { get; set; }
        public decimal Motor_Budget { get; set; }
        public decimal Non_Motor { get; set; }
        public decimal Non_Motor_Budget { get; set; }
        public decimal Total { get; set; }
        public decimal MTD_Budget { get; set; }
        public decimal Achieved_P { get; set; }
        public decimal YTD_Achievement { get; set; }
        public decimal YTD_Budget { get; set; }
        public decimal Achieved_P1 { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

    }
}

