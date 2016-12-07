using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cswb_mmblog.Models.Interface;

namespace cswb_mmblog.Models
{
    public class rmsg : IWebMsg
    {
        public int ret
        {
            get; set;
        }

        public Dictionary<string, string> val
        {
            get; set;
        }

        public string msg
        {
            get; set;
        }
    }
}
