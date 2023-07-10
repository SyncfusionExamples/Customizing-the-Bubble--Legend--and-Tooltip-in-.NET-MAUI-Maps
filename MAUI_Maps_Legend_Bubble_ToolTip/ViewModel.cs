using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Maps_Legend_Bubble_ToolTip
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }

        public ViewModel()
        {
            Data = new ObservableCollection<Model>();
            Data.Add(new Model("India", 411));
            Data.Add(new Model("United States", 34));
            Data.Add(new Model("Kazakhstan", 7));
            Data.Add(new Model("Italy", 201));
            Data.Add(new Model("Korea", 511));
            Data.Add(new Model("China", 149));
            Data.Add(new Model("Philippines", 356));
        }
    }
}
