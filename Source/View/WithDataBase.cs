namespace Mvvm.View
{
    using System.Windows;
    using Mvvm.ViewModel.Models;

    /// <summary>
    /// Base class with reference to daa
    /// </summary>
    public abstract class WithDataBase
        : Window
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WithDataBase"/> class.
        /// </summary>
        protected WithDataBase()
        {
            MainViewModel = MainViewModel.Instance;
            DataContext = MainViewModel;
        }

        /// <summary>
        /// Gets the main view model
        /// </summary>
        public MainViewModel MainViewModel { get; }
    }
}
