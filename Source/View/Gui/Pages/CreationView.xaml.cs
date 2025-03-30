namespace UserManagement.Application.Gui.Pages
{
    using System.Windows.Controls;
    using UserManagement.Application.ViewModels;

    /// <summary>
    /// Interaction logic for CreationView.xaml
    /// </summary>
    public partial class CreationView
        : Page
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreationView"/> class.
        /// </summary>
        public CreationView()
        {
            InitializeComponent();
            DataContext = MainViewModel.Instance;
        }
    }
}
