namespace Domain.Models.Cars
{
    /// <summary>
    /// Parent class for all car variations
    /// </summary>
    public abstract class Car
    {
        /// <summary>
        /// Car name
        /// </summary>
        public string Type { get; set; }
    }
}
