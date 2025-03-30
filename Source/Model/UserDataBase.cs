namespace Mvvm.Model
{
    using Mvvm.Library.Data;

    /// <summary>
    /// The "data base" which stores personal information.
    /// </summary>
    public class UserDataBase
        : List<User>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserDataBase"/> class.
        /// </summary>
        public UserDataBase()
        {
            AddRange(
            [
                new()
                {
                    FirstName = "John",
                    LastName = "Doe",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1971, 7, 17),
                    Addresss =
                    {
                        Street = "123 Main Street, Unit 21",
                        City = "New York City",
                        Region = "New York",
                        PostalCode = "NY 1234",
                    },
                },
                new()
                {
                    FirstName = "Jane",
                    LastName = "Doe",
                    Sex = Sex.Female,
                    DateOfBirth = new DateTime(1976, 2, 21),
                    Addresss =
                    {
                        Street = "123 Main Street, Unit 21",
                        City = "New York City",
                        Region = "New York",
                        PostalCode = "NY 1234",
                    },
                },
                new()
                {
                    FirstName = "Big",
                    LastName = "Bird",
                    Sex = Sex.Male,
                    DateOfBirth = new DateTime(1969, 3, 20),
                    Addresss =
                    {
                        Street = "23 Sesame Street",
                        City = "New York City",
                        Region = "New York",
                        PostalCode = "NY 4567",
                    },
                },
            ]);
        }

        /// <summary>
        /// Gets a value indicating whether the index is in range for the database
        /// </summary>
        /// <param name="index">The index to check</param>
        /// <returns>True if the index is valid</returns>
        public bool IsIndexInRange(int index) => index >= 0 && index < Count;
    }
}
