namespace Mvvm.ViewModel.Models
{
    using Mvvm.Model;

    /// <summary>
    /// Main view model for the application
    /// </summary>
    public class MainViewModel
    {
        /// <summary>
        /// Singleton instance
        /// </summary>
        private static MainViewModel? instance;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        private MainViewModel()
        {
            Data = [];
            Inspection = new UserInspectionViewModel(Data);
        }

        /// <summary>
        /// Gets the singleton instance
        /// </summary>
        public static MainViewModel Instance => instance ??= new MainViewModel();

        /// <summary>
        /// Gets the data used by the application
        /// </summary>
        public UserDataBase Data { get; }

        /// <summary>
        /// Gets the inspection view model
        /// </summary>
        public UserInspectionViewModel Inspection { get; }
    }
}
