using RedeHotel.Lib.Interfaces;
using RedeHotel.Lib.Models;

namespace RedeHotel.Lib.Date.Repository
{
    public class EstadiaRepositorio : BaseRepositorio <Estadia>, IEstadiaRepositorio 
    {
        public EstadiaRepositorio(RedeHotelContext context) : base ( context, context.Estadias)
        {
            
        }
    }
}