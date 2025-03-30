namespace Mvvm.View
{
    using System.Windows;
    using Mvvm.ViewModel.Models;

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