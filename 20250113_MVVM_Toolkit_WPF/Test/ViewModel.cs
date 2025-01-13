using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace _20250113_MVVM_Toolkit_WPF.Test
{
    [INotifyPropertyChanged]
    internal partial class ViewModel
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(NameChange))]
        private string name = string.Empty;

        [ObservableProperty]
        private bool isGreetUser = true;

        public string NameChange => name.ToUpper();

        /*
            ObservableProperty,中，补充了name的get和set属性

           partial void OnNameChanging(string? value);
           partial void OnNameChanged(string? value);
           partial void OnNameChanging(string? oldValue, string? newValue);
           partial void OnNameChanged(string? oldValue, string? newValue);



            RelayCommand 属性公开 CanExecute 属性。
            通过在RelayCommand属性中定义一个确定使用/不使用的函数，您可以控制按钮本身的使用/不使用。
         */



        [RelayCommand(CanExecute = nameof(CanGreetUser))]
        private void GreetUser()
        {
            Name = "HogeHoge";
        }

        private bool CanGreetUser()
        {
            return IsGreetUser;
        }

        [RelayCommand]
        private void GreetUserCan()
        {
            IsGreetUser = true;
        }

        [RelayCommand]
        private void GreetUserNoCan()
        {
            IsGreetUser = false;
        }

        [RelayCommand]
        private void ClearName()
        {
            Name = string.Empty;
        }
    }
}
