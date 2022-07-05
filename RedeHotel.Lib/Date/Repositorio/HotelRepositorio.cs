using RedeHotel.Lib.Interfaces;
using RedeHotel.Lib.Models;

namespace RedeHotel.Lib.Date.Repository
{
    public class HotelRepositorio : BaseRepositorio<Hotel>, IHotelRepositorio
    {
        public HotelRepositorio(RedeHotelContext context) : base (context, context.Hoteis)
        {
            
        }
    }
}