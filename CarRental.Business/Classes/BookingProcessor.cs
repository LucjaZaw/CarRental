using CarRental.Common.Interfaces;
using CarRental.Data.Classes;
using CarRental.Data.Interfaces;

namespace CarRental.Business.Classes
{
    internal class BookingProcessor
    {
        IData _data;
        public BookingProcessor(IData data)
        {
            _data = data;
            
        }
        
    }
}
