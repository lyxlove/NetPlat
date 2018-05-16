using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AJNetLib
{
    public class ReturnInfo
    {
        public bool IsSucessful { get; set; }

        public string Message { get; set; }

        public Dictionary<string, string> DicRet { get; set; }
    }
}
