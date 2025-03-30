namespace Mvvm.ViewModel.Models
{
    using System.Diagnostics;
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
        /// Identification of the date properties
        /// </summary>
        private static readonly string[] DateProperties =
        [
            nameof(Year),
            nameof(Month),
            nameof(Day),
        ];

        /// <summary>
        /// Private field for the <see cref="CurrentUser"/> property;
        /// </summary>
        private User? user;

        /// <summary>
        /// Private field for the <see cref="Year"/> property
        /// </summary>
        private int year = 1990;

        /// <summary>
        /// Private field for the <see cref="Month"/> property
        /// </summary>
        private int month = 1;

        /// <summary>
        /// Private field for the <see cref="Day"/> property
        /// </summary>
        private int day = 1;

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
        public int Year
        {
            get => year;
            set
            {
                if (value != year && TrySetNewDate(year: value))
                {
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the month of birth
        /// </summary>
        public int Month
        {
            get => month;
            set
            {
                if (value != month && TrySetNewDate(month: value))
                {
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the day of birth
        /// </summary>
        public int Day
        {
            get => day;
            set
            {
                if (value != day && TrySetNewDate(day: value))
                {
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
            SetDefaultDate();
        }

        /// <summary>
        /// Save the user that is currently being created
        /// </summary>
        private void SaveAndClose()
        {
            Data.Add(CurrentUser);
            Create();
        }

        /// <summary>
        /// Try and set a new date
        /// </summary>
        /// <param name="year">Year to set</param>
        /// <param name="month">Month to set</param>
        /// <param name="day">Day to set</param>
        /// <returns>True if valid and set, else false</returns>
        private bool TrySetNewDate(int? year = null, int? month = null, int? day = null)
        {
            try
            {
                CurrentUser.DateOfBirth = new(year ?? Year, month ?? Month, day ?? Day);
                this.year = year ?? Year;
                this.month = month ?? Month;
                this.day = day ?? Day;
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Rest the date; also to update properties in view
        /// </summary>
        private void SetDefaultDate()
        {
            Year = 1970;
            Month = 1;
            Day = 1;
        }
    }
}
