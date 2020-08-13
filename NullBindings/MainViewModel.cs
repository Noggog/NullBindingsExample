using Noggog.WPF;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Reactive.Linq;
using System.Text;
using System.Windows.Input;

namespace NullBindings
{
    public class MainViewModel : ViewModel
    {
        [Reactive]
        public SubObject MyObject { get; set; } = new SubObject();

        public IReactiveCommand SetToNullCommand { get; }

        public MainViewModel()
        {
            SetToNullCommand = ReactiveCommand.Create(() => MyObject = null);
        }
    }
}
