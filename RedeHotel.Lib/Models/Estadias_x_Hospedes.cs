namespace RedeHotel.Lib.Models
{
    public class Estadias_x_Hospedes : ModelBase
    {
        public int Id{get; set;}
        public int IdEstadia{get; set;}
        public int IdHospede{get; set;}
        public DateTime DataCadastro{get; set;}
        public DateTime DataUltimaAtualizacao{get; set;}

        public Estadias_x_Hospedes (int id, int idEstadia, int idHospede, DateTime dataCadastro, DateTime dataUltimaAtualizacao)
        : base (id, dataCadastro, dataUltimaAtualizacao)
        {
            Id = id;
            IdEstadia = idEstadia;
            IdHospede = idHospede;
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

        public int GetIdEstadia()
        {
            return IdEstadia;
        }

        public void SetIdEstadia(int idEstadia)
        {
            IdEstadia = idEstadia;
        }

        public int GetIdHospede()
        {
            return IdHospede;
        }

        public void SetIdHospede(int idHospede)
        {
            IdHospede = idHospede;
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