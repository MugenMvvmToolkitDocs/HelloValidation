using System;
using Core.ViewModels;
using MugenMvvmToolkit;

namespace Core
{
    public class App : MvvmApplication
    {
        public override Type GetStartViewModelType()
        {
            return typeof(MainViewModel);
        }
    }
}