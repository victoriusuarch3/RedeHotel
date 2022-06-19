namespace RedeHotel.Lib.Models
{
    public class Servicos_x_Hoteis
    {
        public int Id{get; set;}
        public int IdHotel{get; set;}
        public int IdEstadia{get; set;}
        public DateTime DataCadastro{get; set;}
        public DateTime DataUltimaAtualizacao{get; set;}

        public Servicos_x_Hoteis (int id, int idHotel, int idEstadia, DateTime dataCadastro, DateTime dataUltimaAtualizacao)
        {
            Id = id;
            IdHotel = idHotel;
            IdEstadia = idEstadia;
            DataCadastro = dataCadastro;
            DataUltimaAtualizacao = dataUltimaAtualizacao;
        }
        public Servicos_x_Hoteis()
        {
            
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

        public int GetIdEstadia()
        {
            return IdEstadia;
        }

        public void SetIdEstadia(int idEstadia)
        {
            IdEstadia = idEstadia;
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