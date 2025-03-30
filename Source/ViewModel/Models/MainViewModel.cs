namespace Mvvm.ViewModel.Models
{
    using Mvvm.Model;

    /// <summary>
    /// Main view model for the application
    /// </summary>
    public class MainViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        public MainViewModel()
        {
            Data = new Data();
            Inspection = new InspectionViewModel(Data);
        }

        /// <summary>
        /// Gets the data used by the application
        /// </summary>
        public Data Data { get; }

        /// <summary>
        /// Gets the inspection view model
        /// </summary>
        public InspectionViewModel Inspection { get; }
    }
}
