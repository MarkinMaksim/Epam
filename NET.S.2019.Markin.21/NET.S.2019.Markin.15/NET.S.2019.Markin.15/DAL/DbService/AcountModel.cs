using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET.S._2019.Markin._15.DAL.DbService
{
    public class AcountModel
    {
        public string accid { get; set; }
        public string ownerName { get; set; }
        public string ownerLastname { get; set; }
        public double balance { get; set; }
        public int bonusPoints { get; set; }
        public string acouintType { get; set; }
    }
}
