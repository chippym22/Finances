﻿using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace Finances
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "AboutThis";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}
