using Prism.Mvvm;

namespace HelpDeskPrism.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Help Desk Prism";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public MainWindowViewModel()
        {

        }
    }
}
