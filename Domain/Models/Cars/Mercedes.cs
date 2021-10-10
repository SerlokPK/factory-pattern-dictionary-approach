using Domain.Models.CarParts;

namespace Domain.Models.Cars
{
    /// <summary>
    /// Mercedes car
    /// </summary>
    public class Mercedes : Car
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Mercedes(Automatic automatic)
        {
            Type = "Mercedes";
        }
    }
}
