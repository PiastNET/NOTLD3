using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microsoft.Practices.Prism.Mvvm;
using Spotkania.Controls;
using Spotkania.Interfaces;

namespace Spotkania.Views
{
    public partial class MainPage :  IMainPageViewModel
    {
        public string Title
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public MainPage( string Title )
        {
            this.InitializeComponent();
        }
    }

    //namespace Services  
    //{
    //    public class DialogService : IDialogService
    //    {
    //        public async void Show(string content)
    //        {
    //            var dialog = new MessageDialog(content);
    //            await dialog.ShowAsync();
    //        }
    //    }
    //}

    //namespace DesignTime
    //{
    //    public class MainPageViewModel : Interfaces.IMainPageViewModel
    //    {
    //        public MainPageViewModel()
    //        {
    //            this.Title = "Hello DesignTime";
    //        }

    //        public string Title { get; set; }
    //    }

}     
      
      

      
      
      
      
      
      