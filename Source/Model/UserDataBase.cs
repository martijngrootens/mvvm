namespace Mvvm.Model
{
    using System.Diagnostics;
    using Mvvm.Library.Data;

    /// <summary>
    /// The "data base" which stores personal information.
    /// </summary>
    public class UserDataBase
    {
        /// <summary>
        /// The users
        /// </summary>
        private readonly List<User> users = [];

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
        /// Notification of change in number of users
        /// </summary>
        public event EventHandler? NumUsersChanged;

        /// <summary>
        /// Gets the number of users
        /// </summary>
        public int Count => users.Count;

        /// <summary>
        /// Gets the user at the given index
        /// </summary>
        /// <param name="index">User index</param>
        /// <returns>The user at that index</returns>
        public User this[int index] => users[index];

        /// <summary>
        /// Adds a user to the list, only if none with that id exists
        /// </summary>
        /// <param name="newUser">The new user to add</param>
        public void Add(User newUser)
        {
            var query = from user in users
                        where user.Id == newUser.Id
                        select user;

            if (query.Any())
            {
                Trace.WriteLine($"User with id {newUser} already exists. Ignore.");
            }
            else
            {
                users.Add(newUser);
            }

            NumUsersChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Adds the collection of users
        /// </summary>
        /// <param name="newUsers">The new users to add</param>
        public void AddRange(IEnumerable<User> newUsers)
        {
            users.AddRange(newUsers.Distinct());

            NumUsersChanged?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// Gets a value indicating whether the index is in range for the database
        /// </summary>
        /// <param name="index">The index to check</param>
        /// <returns>True if the index is valid</returns>
        public bool IsIndexInRange(int index) => index >= 0 && index < Count;
    }
}
