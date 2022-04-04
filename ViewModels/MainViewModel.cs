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
        public int Clicks { get; set; }

        public ICommand ClickAdd
        {
            get
            {
                return new DelegateCommand(
                    () => Clicks++, () => Clicks < 10);
            }
        }
    }
}
