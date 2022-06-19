namespace RedeHotel.Lib.Models
{
    public class Estadia
    {
       public int Id {get; set;}
       public int IdResposavel{get; set;}
       public int IdQuarto{get; set;}
       public DateTime DataEntrada{get; set;}
       public DateTime DataSaida {get; set;}
       public DateTime DataCadastro {get; set;}
       public DateTime DataUltimaAtualizacao{get; set;}

       public Estadia (int id, int idResposavel, int idQuarto, DateTime dataEntrada, DateTime dataSaida, DateTime dataCadastro, DateTime dataUltimaAtualizacao)
       {
        Id = id;
        IdResposavel = idResposavel;
        IdQuarto = idQuarto;
        DataEntrada = dataEntrada;
        DataSaida = dataSaida;
        DataCadastro = dataCadastro;
        DataUltimaAtualizacao = dataUltimaAtualizacao;
       }
       public Estadia()
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

       public int GetIdResponsavel()
       {
        return IdResposavel;
       }

       public void SetIdResponsavel(int idResposavel)
       {
        IdResposavel = idResposavel;
       }

       public int GetIdQuarto()
       {
        return IdQuarto;
       }

       public void SetIdQuarto(int idQuarto)
       {
        IdQuarto = idQuarto;
       }

       public DateTime GetDataEntrada()
       {
        return DataEntrada;
       }

       public void SetDataEntrada(DateTime dataEntrada)
       {
        DataEntrada = dataEntrada;
       }

       public DateTime GetDataSaida()
       {
        return DataSaida;
       }

       public void SetDataSaida(DateTime dataSaida)
       {
        DataSaida = dataSaida;
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