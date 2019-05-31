﻿using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace XamShell.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }



        public AboutViewModel(AboutViewModel viewModel)
        {
        }

        public ICommand OpenWebCommand { get; }
    }
}