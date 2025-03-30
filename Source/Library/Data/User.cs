namespace Mvvm.Library.Data
{
    using System;

    /// <summary>
    /// Representation of a person.
    /// </summary>
    public class User
    {
        /// <summary>
        /// Gets or setst the identifier.
        /// </summary>
        public Guid Id { get; set; } = Guid.NewGuid();

        /// <summary>
        /// Gets or sets the data of birth.
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        public string FirstName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the sex.
        /// </summary>
        public Sex Sex { get; set; } = Sex.X;

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        public Addresss Addresss { get; set; } = new();

        /// <summary>
        /// Gets the full name.
        /// </summary>
        public string FullName => $"{FirstName} {LastName}";

        /// <summary>
        /// Gets the  birthday as string
        /// </summary>
        public string BirthDay => DateOfBirth?.ToShortDateString() ?? "-";

        /// <inheritdoc/>
        public override string ToString()
            => $"{GetType().Name}: {FullName} ({BirthDay})";
    }
}
