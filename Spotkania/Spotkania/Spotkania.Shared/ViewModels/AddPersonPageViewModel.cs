using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.Prism.Mvvm;
using Spotkania.Interfaces;

namespace Spotkania.ViewModels
{
    class AddPersonPageViewModel : ViewModel , IAddPersonPageViewModel
    {
        public void Show(string content)
        {
            System.Diagnostics.Debug.WriteLine("Witaj świecie");
        }
    }
}
