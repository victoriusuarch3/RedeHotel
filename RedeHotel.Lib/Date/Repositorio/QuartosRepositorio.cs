using RedeHotel.Lib.Interfaces;
using RedeHotel.Lib.Models;

namespace RedeHotel.Lib.Date.Repository
{
    public class QuartosRepositorio : BaseRepositorio<Quartos>, IQuartosRepositorio
    {
        public QuartosRepositorio(RedeHotelContext context) : base (context, context.Quartos)
        {

        }
    }
}