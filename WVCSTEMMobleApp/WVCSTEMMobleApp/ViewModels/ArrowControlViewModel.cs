using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace WVCSTEMMobleApp.ViewModels
{
    public class ArrowControlViewModel : BaseViewModel
    {
        public ArrowControlViewModel()
        {
            Title = "Arrow Control";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}
