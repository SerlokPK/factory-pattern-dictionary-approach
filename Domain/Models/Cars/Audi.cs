using Domain.Models.CarParts;

namespace Domain.Models.Cars
{
    /// <summary>
    /// Audi car 
    /// </summary>
    public class Audi : Car
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Audi(Manual manual, Seat seat)
        {
            Type = "Audi";
        }
    }
}
