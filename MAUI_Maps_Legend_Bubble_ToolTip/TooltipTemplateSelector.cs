using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Maps_Legend_Bubble_ToolTip
{
    public class TooltipTemplateSelector : DataTemplateSelector
    {
        public DataTemplate Low { get; set; }
        public DataTemplate High { get; set; }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((Model)item).Density > 250 ? High : Low;
        }
    }
}
