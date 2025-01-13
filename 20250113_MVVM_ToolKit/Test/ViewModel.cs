using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace _20250113_MVVM_ToolKit.Test
{
    [INotifyPropertyChanged]
    internal partial class ViewModel
    {
        [ObservableProperty]
        public string? Name = "Hoge";

    }
}
