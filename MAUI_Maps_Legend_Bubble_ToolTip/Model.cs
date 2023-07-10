using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Maps_Legend_Bubble_ToolTip
{
    public class Model
    {
        public String Country { get; set; }
        public int Density { get; set; }

        public Model(string country, int density)
        {
            Country = country;
            Density = density;
        }
    }
}
