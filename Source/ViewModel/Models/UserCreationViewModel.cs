namespace Mvvm.ViewModel.Models
{
    using System.Windows.Input;
    using Mvvm.Library.Data;
    using Mvvm.Model;
    using Mvvm.ViewModel.Library;

    /// <summary>
    /// Class for creating new database records
    /// </summary>
    public class UserCreationViewModel
        : ViewModelBase
    {
        /// <summary>
        /// Private field for the <see cref="CurrentUser"/> property;
        /// </summary>
        private User? user;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserCreationViewModel"/> class.
        /// </summary>
        /// <param name="data">The data container</param>
        public UserCreationViewModel(UserDataBase data)
            : base(data)
        {
            Create();
            CreateCommand = new Command { Action = Create };
            SaveCommand = new Command { Action = Save };
        }

        /// <summary>
        /// Gets the person currently being created
        /// </summary>
        public User CurrentUser
        {
            get => user;
            private set
            {
                if (value != user)
                {
                    user = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets the command for creating a new user
        /// </summary>
        public ICommand CreateCommand { get; }

        /// <summary>
        /// Gets the command for saving the current user
        /// </summary>
        public ICommand SaveCommand { get; }

        /// <summary>
        /// Start creation of a new user
        /// </summary>
        private void Create() => CurrentUser = new User();

        /// <summary>
        /// Save the user that is currently being created
        /// </summary>
        private void Save() => Data.Add(CurrentUser);
    }
}
