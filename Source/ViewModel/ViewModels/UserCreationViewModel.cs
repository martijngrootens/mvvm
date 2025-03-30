namespace UserManagement.Application.ViewModels
{
    using System.Windows.Input;
    using UserManagement.Application.Library;
    using UserManagement.Data;
    using UserManagement.Library.Data;

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
        /// Private field for the <see cref="DateString"/> property
        /// </summary>
        private string? dateString;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserCreationViewModel"/> class.
        /// </summary>
        /// <param name="data">The data container</param>
        public UserCreationViewModel(UserDataBase data)
            : base(data)
        {
            Create();
            SaveCommand = new Command { Action = SaveAndClose };
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
        /// Gets or sets the year of birth
        /// </summary>
        public string DateString
        {
            get => dateString;
            set
            {
                if (value != dateString)
                {
                    dateString = value;
                    if (DateTime.TryParse(value, out DateTime date) && CurrentUser.DateOfBirth != date)
                    {
                        CurrentUser.DateOfBirth = date;
                        OnPropertyChanged(nameof(CurrentUser));
                    }

                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets the command for saving the current user
        /// </summary>
        public ICommand SaveCommand { get; }

        /// <summary>
        /// Start creation of a new user, keep some properties
        /// </summary>
        private void Create()
        {
            // Take over sex to keep the drop down state valid
            CurrentUser = new()
            {
                Sex = CurrentUser?.Sex ?? Sex.X,
            };

            // Date must be cleared or copied
            DateString = string.Empty;
        }

        /// <summary>
        /// Save the user that is currently being created
        /// </summary>
        private void SaveAndClose()
        {
            Data.Add(CurrentUser);
            Create();
        }
    }
}
