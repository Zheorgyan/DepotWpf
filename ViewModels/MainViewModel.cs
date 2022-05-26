namespace WpfApp.ViewModels
{
    /// <summary>
    /// Модель представления главного окна
    /// </summary>
    class MainViewModel : INotifyPropertyChanged
    {

        public string User
        {
            get
            {
                return App.AuthenticationProvider.Login;
            }
        }

        public string Roles
        {
            get
            {
                return string.Join(", ", App.AuthenticationProvider.Roles);
            }
        }

        bool _isLoading = false;
        public bool IsLoading
        {
            get
            {
                return _isLoading;
            }
            set
            {
                _isLoading = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(IsLoadingVisibility));
            }
        }

        public Visibility IsLoadingVisibility
        {
            get
            {
                return IsLoading ? Visibility.Visible : Visibility.Collapsed;
            }
        }

        public MainViewModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
