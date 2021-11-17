using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private int _value;

        public int Value 
        { 
            get {  return _value; }
            set
            {
                Set(ref _value, value);
            } 
        }

        public MainViewModel()
        {
            Task.Run(() => {
                Task.Delay(2000).Wait();

                for (int i = 0; i < 100; i++)
                {
                    Value++;
                    Task.Delay(500).Wait();
                }
            });
        }

        
    }
}
