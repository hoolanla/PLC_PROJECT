using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MODEL
{
    public class Production
    {
        public System.Collections.ArrayList line { get; set; }

    }

    public class Data

    { 
        public string Line_Name { get; set; }
        public string Production_active { get; set; }
        public string Production_warning { get; set; }
        public string Line_Manual { get; set; }
        public string Stopper_active { get; set; }
        public string Time_loop { get; set; }
        public int Time_loop_rec { get; set; }
    }


}
