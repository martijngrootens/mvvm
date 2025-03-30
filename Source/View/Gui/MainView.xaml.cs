namespace UserManagement.Application.Gui
{
    using System.Windows;
    using UserManagement.Application.ViewModels;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView
        : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainView"/> class.
        /// </summary>
        public MainView()
        {
            InitializeComponent();
            DataContext = MainViewModel.Instance;
        }
    }
}