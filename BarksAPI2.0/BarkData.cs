using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarksAPI2._0
{
    public class BarkData
    {
        public int id { get; set; }
        public int Accountid { get; set; }
        public string AccountNickname { get; set; }
        public DateTime BarkDate { get; set; }
        public string BarkTitel { get; set; }
        public string BarkText { get; set; }
        public int BarkActive { get; set; }
    }
}
