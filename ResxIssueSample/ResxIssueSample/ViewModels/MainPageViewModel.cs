using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ResxIssueSample.i18n;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ResxIssueSample.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string _welcomeMessage;
        public string WelcomeMessage
        {
            get => _welcomeMessage;
            set => SetProperty(ref _welcomeMessage, value, nameof(WelcomeMessage));
        }

        private string _secretMessage;
        public string SecretMessage
        {
            get => _secretMessage;
            set => SetProperty(ref _secretMessage, value, nameof(SecretMessage));
        }

        private string _okButtonText;
        public string OkButtonText
        {
            get => _okButtonText;
            set => SetProperty(ref _okButtonText, value, nameof(OkButtonText));
        }

        private string _cancelButtonText;
        public string CancelButtonText
        {
            get => _cancelButtonText;
            set => SetProperty(ref _cancelButtonText, value, nameof(CancelButtonText));
        }

        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
            WelcomeMessage = AppResources.WelcomeMessage;
            SecretMessage = AppResources.LittleOrphanAnnie;
            OkButtonText = AppResources.OkButtonText;
            CancelButtonText = AppResources.NoThanksButtonText;
        }
    }
}
