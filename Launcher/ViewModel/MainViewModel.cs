using GalaSoft.MvvmLight.Command;
using Launcher.View;
using System.Windows.Controls;
using System.Windows.Input;

namespace Launcher.ViewModel
{
    internal class MainViewModel : ViewModelBase
    {
        private Page _currPage = new WowPage();
        private Page Wow = new WowPage();
        private Page W3 = new W3Page();
        private Page Sc = new SCPage();
        private Page Sc2 = new SC2Page();
        private Page Ow = new OverwatchPage();
        private Page Hs = new HSPage();
        private Page Hots = new HOTSPage();
        private Page Diablo = new DiabloPage();

        public Page CurrPage
        {
            get => _currPage;
            set => Set(ref _currPage, value);
        }

        public ICommand OpenHSPage
        {
            get 
            {
                return new RelayCommand(() => CurrPage = Hs);
            }
        }
        public ICommand OpenWowPage
        {
            get
            {
                return new RelayCommand(() => CurrPage = Wow);
            }
        }
        public ICommand OpenSCPage
        {
            get
            {
                return new RelayCommand(() => CurrPage = Sc);
            }
        }
        public ICommand OpenSC2Page
        {
            get
            {
                return new RelayCommand(() => CurrPage = Sc2);
            }
        }
        public ICommand OpenHOTSPage
        {
            get
            {
                return new RelayCommand(() => CurrPage = Hots);
            }
        }
        public ICommand OpenOWPage
        {
            get
            {
                return new RelayCommand(() => CurrPage = Ow);
            }
        }
        public ICommand OpenDiabloPage
        {
            get
            {
                return new RelayCommand(() => CurrPage = Diablo);
            }
        }
        public ICommand OpenW3Page
        {
            get
            {
                return new RelayCommand(() => CurrPage = W3);
            }
        }
    }
}
