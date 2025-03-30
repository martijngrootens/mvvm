namespace Mvvm.ViewModel.Models
{
    using System.Diagnostics;
    using System.Windows.Input;
    using Mvvm.Library.Data;
    using Mvvm.Model;
    using Mvvm.ViewModel.Library;

    /// <summary>
    /// View model for inspecting database records
    /// </summary>
    public class UserInspectionViewModel
        : ViewModelBase
    {
        /// <summary>
        /// Private field for the <see cref="NextIndex"/> property.
        /// </summary>
        private int nextIndex = 0;

        /// <summary>
        /// Private field for the <see cref="NextIndex"/> property.
        /// </summary>
        private int currentIndex = 0;

        /// <summary>
        /// Private field for the <see cref="Selection"/> property
        /// </summary>
        private User? current;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInspectionViewModel"/> class.
        /// </summary>
        /// <param name="data">The data set to use</param>
        public UserInspectionViewModel(UserDataBase data)
            : base(data)
        {
            SelectCommand = new Command { Action = Select };
            NextIndex = 0;
            Select();
        }

        /// <summary>
        /// Gets the index of the displayed person
        /// </summary>
        public int CurrentIndex
        {
            get => currentIndex;
            private set
            {
                if (currentIndex != value && Data.IsIndexInRange(value))
                {
                    currentIndex = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets or sets the index of the next person to display
        /// </summary>
        public int NextIndex
        {
            get => nextIndex;
            set
            {
                if (nextIndex != value)
                {
                    nextIndex = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets the selected person.
        /// </summary>
        public User CurrentUser
        {
            get => current;
            private set
            {
                if (current != value)
                {
                    current = value;
                    OnPropertyChanged();
                }
            }
        }

        /// <summary>
        /// Gets the command for selecting the next user
        /// </summary>
        public ICommand SelectCommand { get; }

        /// <summary>
        /// Select the next person from th database
        /// </summary>
        private void Select()
        {
            Trace.WriteLine($"Select [{NextIndex}]");
            CurrentIndex = NextIndex;
            CurrentUser = Data[CurrentIndex];
        }
    }
}
