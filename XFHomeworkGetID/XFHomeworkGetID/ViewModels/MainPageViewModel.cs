using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XFHomeworkGetID.ViewModels
{
    using System.ComponentModel;
    using Prism.Events;
    using Prism.Navigation;
    using Prism.Services;
    public class MainPageViewModel : INotifyPropertyChanged, INavigationAware
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public DelegateCommand GetIDCommand { get; set; }

        private readonly INavigationService navigationService;
        private readonly IPageDialogService dialogService;
        private readonly IGetID getID;

        public MainPageViewModel(INavigationService navigationService,IPageDialogService dialogService,IGetID getID)
        {
            this.navigationService = navigationService;
            this.dialogService = dialogService;
            this.getID = getID;
            GetIDCommand = new DelegateCommand(() =>
            {
                string result = getID.GetdeviceID();
                dialogService.DisplayAlertAsync("通知", result, "確認");
            });

        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
        }

    }
}
