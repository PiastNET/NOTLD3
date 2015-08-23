using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Navigation;
using Microsoft.Practices.Prism.Mvvm;
using Spotkania.Interfaces;

namespace Spotkania.ViewModels
{
    public partial class MainPageViewModel : ViewModel, IMainPageViewModel
    {

        private IAddPersonPageViewModel _dialogService;
        private string _Title = default(string);

        public MainPageViewModel(IAddPersonPageViewModel dialogService)
        {
            this._dialogService = dialogService;
        }

#pragma REGION PUBLIC_METHODS
        [RestorableState]
        public string Title
        {
            get { return _Title; }
            set { SetProperty(ref _Title, value); }
        }

        public override void OnNavigatedTo(object navigationParameter, NavigationMode navigationMode,
            Dictionary<string, object> viewModelState)
        {
            this.Title = "Hello Runtime";
            _dialogService.Show(this.Title);
        }
    }
#pragma ENDREGION
}