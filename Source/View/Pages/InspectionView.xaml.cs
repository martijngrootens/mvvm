namespace Mvvm.View
{
    using System.Windows.Controls;
    using Mvvm.ViewModel.Models;

    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class InspectionView : Page
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
