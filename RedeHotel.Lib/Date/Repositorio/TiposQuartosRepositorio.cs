using RedeHotel.Lib.Interfaces;
using RedeHotel.Lib.Models;

namespace RedeHotel.Lib.Date.Repository
{
    public class TiposQuartosRepositorio : BaseRepositorio<TiposQuartos>, ITiposQuartosRepositorio
    {
        public TiposQuartosRepositorio(RedeHotelContext context) : base (context, context.TiposQuartos)
        {
            
        }        
    }
}