namespace UserManagement.Application.Gui.Pages
{
    using System.Windows.Controls;
    using UserManagement.Application.ViewModels;

    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class InspectionView
        : Page
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InspectionView"/> class.
        /// </summary>
        public InspectionView()
        {
            InitializeComponent();
            DataContext = MainViewModel.Instance;
        }
    }
}
