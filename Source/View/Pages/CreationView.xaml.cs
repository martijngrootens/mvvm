namespace Mvvm.View.Pages
{
    using System.Windows.Controls;
    using Mvvm.ViewModel.Models;

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
