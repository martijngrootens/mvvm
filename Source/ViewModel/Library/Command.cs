namespace Mvvm.ViewModel.Library
{
    using System;
    using System.Windows.Input;

    /// <summary>
    /// Command implementation
    /// </summary>
    public class Command
        : ICommand
    {
        /// <summary>
        /// Private field for the <see cref="Action"/> property.
        /// </summary>
        private Action? action;

        /// <inheritdoc/>
        public event EventHandler? CanExecuteChanged;

        /// <summary>
        /// Gets or sets the method to call.
        /// </summary>
        public Action? Action
        {
            get => action;
            set
            {
                if (action != value)
                {
                    action = value;
                    CanExecuteChanged?.Invoke(this, EventArgs.Empty);
                }
            }
        }

        /// <inheritdoc/>
        public bool CanExecute(object? parameter) => Action is not null;

        /// <inheritdoc/>
        public void Execute(object? parameter) => Action?.Invoke();
    }
}
