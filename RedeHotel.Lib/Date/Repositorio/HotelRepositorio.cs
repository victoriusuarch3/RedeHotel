using RedeHotel.Lib.Context;
using RedeHotel.Lib.Exceptions;
using RedeHotel.Lib.Interfaces;
using RedeHotel.Lib.Models;
using Microsoft.EntityFrameworkCore;

namespace RedeHotel.Lib.Date.Repository
{
    public class HotelRepositorio : BaseRepositorio<Hotel>, IHotelRepositorio
    {
        public HotelRepositorio(RedeHotelContext context) : base (context, context.Hoteis)
        {
            
        }
    }
}