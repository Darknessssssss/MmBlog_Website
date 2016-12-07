using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cswb_mmblog.Models.Interface
{
    public interface IWebMsg
    {
        int ret { get; set; }
        string msg { get; set; }
        Dictionary<string,string> val { get; set; }
    }
}
