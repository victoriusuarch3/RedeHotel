using RedeHotel.Lib.Interfaces;
using RedeHotel.Lib.Models;

namespace RedeHotel.Lib.Date.Repository
{
    public class ServicosRepositorio : BaseRepositorio<Servicos>, IServicosRepositorio
    {
        public ServicosRepositorio(RedeHotelContext context) : base(context, context.Servicos)
        {
            
        }
    }
}