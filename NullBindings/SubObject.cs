using Noggog.WPF;
using ReactiveUI.Fody.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace NullBindings
{
    public class SubObject : ViewModel
    {
        [Reactive]
        public string MyText { get; set; } = "Hello World";
    }
}
