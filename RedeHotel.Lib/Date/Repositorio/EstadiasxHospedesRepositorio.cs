using RedeHotel.Lib.Interfaces;
using RedeHotel.Lib.Models;

namespace RedeHotel.Lib.Date.Repository
{
    public class EstadiasxHospedeRepositorio : BaseRepositorio<EstadiasxHospedes>, IEstadiaxHospedeRepositorio
    {
        public EstadiasxHospedeRepositorio(RedeHotelContext context) : base (context, context.EstadiasXHospedes)
        {
            
        }
    }
}