using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Practices.Unity;

namespace Spotkania
{
    internal sealed partial class App
    {
#if WINDOWS_PHONE_APP
        private TransitionCollection transitions;
#endif
        //Bootstrap: App singleton service declarations
        private TileUpdater _tileUpdater;

        private readonly IUnityContainer _container = new UnityContainer();
    //    public IEventAggregator EventAggregator { get; set; }

        public App()
        {
            this.InitializeComponent();
            this.RequestedTheme = ApplicationTheme.Dark;
        }



        protected override void OnRegisterKnownTypesForSerialization()
        {
            // Set up the list of known types for the SuspensionManager
            SessionStateService.RegisterKnownType(typeof(Address));
         //  SessionStateService.RegisterKnownType(typeof(PaymentMethod));
         //  SessionStateService.RegisterKnownType(typeof(UserInfo));
         //  SessionStateService.RegisterKnownType(typeof(CheckoutDataViewModel));
         //  SessionStateService.RegisterKnownType(typeof(ObservableCollection<CheckoutDataViewModel>));
         //  SessionStateService.RegisterKnownType(typeof(ShippingMethod));
         //  SessionStateService.RegisterKnownType(typeof(ReadOnlyDictionary<string, ReadOnlyCollection<string>>));
         //  SessionStateService.RegisterKnownType(typeof(Order));
         //  SessionStateService.RegisterKnownType(typeof(Product));
         //  SessionStateService.RegisterKnownType(typeof(ReadOnlyCollection<Product>));
        }
      //protected ViewModelLocator.Set((viewType) =>    
      // {         
      // var viewModelTypeName = string.Format(CultureInfo.InvariantCulture,      
      // "AdventureWorks.UILogic.ViewModels.{0}ViewModel," +
      // "AdventureWorks.UILogic, Version=1.0.0.0, Culture=neutral,  " +
      // "                     PublicKeyToken=634ac3171ee5190a", viewType.Name);
      // var viewModelType = Type.GetType(viewModelTypeName);
      // return viewModelType;
      // }); 

        protected override Task OnLaunchApplicationAsync(LaunchActivatedEventArgs args)
        {
            throw new NotImplementedException();
        }

        protected override Task OnInitializeAsync(IActivatedEventArgs args)
        {
            
            _container.RegisterInstance(NavigationService);
            _container.RegisterType<IAccountService, AccountService>(new ContainerControlledLifetimeManager());
            _container.RegisterType<IShippingAddressUserControlViewModel,ShippingAddressUserControlViewModel>();  

            ViewModelLocator.SetDefaultViewTypeToViewModelTypeResolver((viewType)
                =>
            {
                return viewModelType;
            });  
        }


        public enum Experiences { Main }

        protected Task OnLaunchApplication(LaunchActivatedEventArgs args)
        {
            if (args != null && string.IsNullOrEmpty(args.Arguments))
            {
                NavigationService.Navigate("Main", args.Arguments);
            }

            else
            {
                NavigationService.Navigate("AddPerson", null);
            }

            Window.Current.Activate();
            return Task.FromResult<object>(null);
        }

        protected override object Resolve(Type type)
        {
            return _container.Resolve(type);
        }

    }
}