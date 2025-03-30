namespace Mvvm.ViewModel.Models
{
    /// <summary>
    /// Main view model for the application
    /// </summary>
    public class MainViewModel
        : ViewModelBase
    {
        /// <summary>
        /// Singleton instance
        /// </summary>
        private static MainViewModel? instance;

        /// <summary>
        /// Private field for the <see cref="NumUsers"/> property
        /// </summary>
        private int numUsers;

        /// <summary>
        /// Initializes a new instance of the <see cref="MainViewModel"/> class.
        /// </summary>
        private MainViewModel()
            : base(new())
        {
            Inspection = new(Data);
            Creation = new(Data);

            Data.NumUsersChanged += OnNumUsersChanged;
            NumUsers = Data.Count;
        }

        /// <summary>
        /// Gets the singleton instance
        /// </summary>
        public static MainViewModel Instance => instance ??= new MainViewModel();

        /// <summary>
        /// Gets the number of users in the database
        /// </summary>
        public int NumUsers
        {
            get => numUsers;
            private set
            {
                if (value != numUsers)
                {
                    numUsers = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets the inspection view model
        /// </summary>
        public UserInspectionViewModel Inspection { get; }

        /// <summary>
        /// Gets the inspection view model
        /// </summary>
        public UserCreationViewModel Creation { get; }

        /// <summary>
        /// Event handler for a change in the number of user in the database
        /// </summary>
        /// <param name="sender">Source</param>
        /// <param name="args">Arguments</param>
        private void OnNumUsersChanged(object? sender, EventArgs args) => NumUsers = Data.Count;
    }
}
