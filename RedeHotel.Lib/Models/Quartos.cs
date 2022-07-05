namespace RedeHotel.Lib.Models
{
    public class Quartos : ModelBase
    {
        public int Id{get; set;}
        public int IdHotel{get; set;}
        public int IdTipoQuarto{get; set;}
        public int Numero{get; set;}
        public int Andar{get; set;}
        public DateTime DataCadastro{get; set;}
        public DateTime DataUltimaAtualizacao{get; set;}
        public virtual List<Estadia> Estadias {get; set;}
        public virtual Hotel Hotel{get; set;}

        public Quartos (int id, int idHotel, int idTipoQuarto, int numero, int andar, DateTime dataCadastro, DateTime dataUltimaAtualizacao)
        : base (id, dataCadastro, dataUltimaAtualizacao)
        {
            Id = id;
            IdHotel = idHotel;
            IdTipoQuarto = idTipoQuarto;
            Numero = numero;
            Andar = andar;
            DataCadastro = dataCadastro;
            DataUltimaAtualizacao = dataUltimaAtualizacao;
        }

        public int GetId()
        {
            return Id;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public int GetIdHotel()
        {
            return IdHotel;
        }

        public void SetIdHotel(int idHotel)
        {
            IdHotel = idHotel;
        }

        public int GetIdTipoQuarto()
        {
            return IdTipoQuarto;
        }

        public void SetIdTipoQuarto(int idTipoQuarto)
        {
            IdTipoQuarto = idTipoQuarto;
        }

        public int GetNumero()
        {
            return Numero;
        }

        public void SetNumero(int numero)
        {
            Numero = numero;
        }

        public int GetAndar()
        {
            return Andar;
        }

        public void SetAndar(int andar)
        {
            Andar = andar;
        }

        public DateTime GetDataCadastro()
        {
            return DataCadastro;
        }

        public void SetDataCadastro(DateTime dataCadastro)
        {
            DataCadastro = dataCadastro;
        }

        public DateTime GetDataUltimaAtualizacao()
        {
            return DataUltimaAtualizacao;
        }

        public void SetDataUltimaAtualizacao(DateTime dataUltimaAtualizacao)
        {
            DataUltimaAtualizacao = dataUltimaAtualizacao;
        }
    }
}