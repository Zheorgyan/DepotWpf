namespace WpfApp
{
    /// <summary>
    /// Диалоговое окно авторизации в системе
    /// </summary>
    public partial class LoginWindow : EditorWindow
    {
        public LoginWindow(DbContext dbContext, DataObjectBase model) : base(dbContext, model)
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            ResizeMode = ResizeMode.NoResize;
        }

        RadPasswordBox passwordControl;

        protected override UIElement CreateControl(PropertyInfo property)
        {
            if (property.Name == "Password")
            {
                passwordControl = new RadPasswordBox();
                passwordControl.Password = ((LoginViewModel)model.BusinessObject).Password;
                return passwordControl;
            }
            return base.CreateControl(property);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            ((LoginViewModel)model.BusinessObject).Password = passwordControl.Password;
            base.OnClosing(e);
        }
    }
}
