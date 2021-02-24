using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_UI_Framework
{
    public class Config
    {
        public static bool NavigateToBlankBeforeTest
        {
            get { return Convert.ToBoolean("NavigateToBlankPage"); }
        }
    }
}
