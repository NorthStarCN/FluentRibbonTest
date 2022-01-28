using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FluentRibbonTest
{
    public class MainWindowsViewModel : ObservableRecipient
    {
        private bool _isTabGroupVisible;

        public bool IsTabGroupVisible
        {
            get { return _isTabGroupVisible; }
            set { SetProperty(ref _isTabGroupVisible, value); }
        }

        private RelayCommand? showHideTab;
        
        public ICommand ShowHideTab => showHideTab ??= new RelayCommand(PerformShowHideTab);

        private void PerformShowHideTab()
        {
            IsTabGroupVisible = !IsTabGroupVisible; 
        }
    }
}
