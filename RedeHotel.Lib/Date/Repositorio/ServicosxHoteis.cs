using RedeHotel.Lib.Interfaces;
using RedeHotel.Lib.Models;
namespace RedeHotel.Lib.Date.Repository
{
    public class ServicosxHoteisRepositorio : BaseRepositorio<ServicosxHoteis>, IServicosxHoteisRepositorio
    {
        public ServicosxHoteisRepositorio(RedeHotelContext context) : base (context, context.ServicosxHoteis)
        {
            
        }   
    }
}