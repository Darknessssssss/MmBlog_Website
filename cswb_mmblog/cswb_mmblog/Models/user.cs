using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cswb_mmblog.Models.Interface;

namespace cswb_mmblog.Models
{
    [Serializable]
    public class user: IWebMsg
    {
        public int id { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string nickname { get; set; }
        public string password { get; set; }
        public int type { get; set; }
        public string faceurl { get; set; }
        public DateTime regtime { get; set; }
        public DateTime llitime { get; set; }
        public string llide { get; set; }
        public string lliip { get; set; }

        public int ret
        {
            get;
            set;
        }

        public string msg
        {
            get;
            set;
        }
        public Dictionary<string, string> val { get; set; }
        public user()
        {

        }
    }
}
