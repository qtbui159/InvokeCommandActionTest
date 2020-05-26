using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvokeCommandActionTest.ViewModels
{
    class MainWindowViewModel : BindableBase
    {
        public bool Idle { get => m_Idle; private set => SetProperty(ref m_Idle, value); }
        private bool m_Idle = false;

        public DelegateCommand<object> KeyUpCommand { get; private set; }

        public MainWindowViewModel()
        {
            KeyUpCommand = new DelegateCommand<object>(KeyUpCommandProc);
        }

        private void KeyUpCommandProc(object obj)
        {
            
        }
    }
}
