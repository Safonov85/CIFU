using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace CIFU.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://duckduckgo.com/")));
        }

        public ICommand OpenWebCommand { get; }
    }
}