using System;
using System.Collections.Generic;
using System.Text;
using Prism.Mvvm;

namespace HelpDeskPrism.Infrastructure
{
    public class ViewModelBase : BindableBase
    {
        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
    }
}
