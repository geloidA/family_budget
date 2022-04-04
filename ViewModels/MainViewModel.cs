using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace family_budget.ViewModels
{
    class MainViewModel : ViewModelBase
    { 
        private int _clicks;
        public int Clicks
        {
            get { return _clicks; }
            set 
            {
                _clicks = value;
                RaisePropertyChanged(() => Clicks);
            }
        }

        public ICommand ClickAdd
        {
            get
            {
                return new DelegateCommand(
                    () => Clicks++, () => Clicks < 10);
            }
        }

        public ICommand ClickRemove
        {
            get
            {
                return new DelegateCommand(
                    () => Clicks--);
            }
        }
    }
}
