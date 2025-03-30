namespace Mvvm.View
{
    using System.Windows;
    using Mvvm.ViewModel.Models;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
        : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            MainViewModel = MainViewModel.Instance;
            DataContext = MainViewModel;
        }

        /// <summary>
        /// Gets the main view model
        /// </summary>
        public MainViewModel MainViewModel { get; }
    }
}