namespace Mvvm.ViewModel.Models
{
    using System.ComponentModel;
    using System.Runtime.CompilerServices;
    using Mvvm.Model;

    /// <summary>
    /// Base class for view models that work with the data
    /// </summary>
    /// <param name="data">The data set to inspect</param>
    public class DataViewModelBase(Data data)
        : INotifyPropertyChanged
    {
        /// <inheritdoc/>
        public event PropertyChangedEventHandler? PropertyChanged;

        /// <summary>
        /// Gets the reference to the data
        /// </summary>
        protected Data Data { get; } = data;

        /// <summary>
        /// Invokes the <see cref="PropertyChanged"/> event if the value is indeed changed.
        /// </summary>
        /// <param name="propertyName">The name of the changed property</param>
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}
