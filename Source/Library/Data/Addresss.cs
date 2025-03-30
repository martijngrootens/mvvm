namespace Mvvm.Library.Data
{
    /// <summary>
    /// Representation of an address for a house or building.
    /// </summary>
    public class Addresss
    {
        /// <summary>
        /// Gets or sets the street name.
        /// </summary>
        public string Street { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the city.
        /// </summary>
        public string City { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the region.
        /// </summary>
        public string Region { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        public string PostalCode { get; set; } = string.Empty;
    }
}
