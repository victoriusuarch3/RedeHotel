using RedeHotel.Lib.Exceptions;

namespace RedeHotel.Lib.Models
{
    public class Hotel : ModelBase
    {
        public int Id{get; set;}
        public string Nome{get; set;}
        public string Endereco{get; set;}
        public string Cep{get; set;}
        public string Descricao{get; set;}
        public string Telefone{get; set;}
        public string Email{get; set;}
        public DateTime HorarioCheckIn{get; set;}
        public DateTime HorarioCheckOut{get; set;}
        public DateTime DataCadastro{get; set;}
        public DateTime DataUltimaAtualizacao{get; set;}
        public virtual List<Quartos> Quartos{get; set;}

        public Hotel (int id, string nome, string endereco, string cep, string descricao, string telefone, string email, DateTime horarioCheckIn, DateTime horarioCheckOut, DateTime dataCadastro, DateTime dataUltimaAtualizacao)
        : base (id, dataCadastro, dataUltimaAtualizacao)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Cep = cep;
            Descricao = descricao;
            Telefone = telefone;
            Email = email;
            HorarioCheckIn = horarioCheckIn;
            HorarioCheckOut = horarioCheckOut;
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

        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public string GetEndereco()
        {
            return Endereco;
        }

        public void SetEndereco(string endereco)
        {
            Endereco = endereco;
        }

        public string GetCep()
        {
            return Cep;
        }

        public void SetCep(string cep)
        {
            Cep = cep;
        }

        public string GetDescricao()
        {
            return Descricao;
        }

        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public string GetTelefone()
        {
            return Telefone;
        }

        public void SetTelefone(string telefone)
        {
            Telefone = telefone;
        }

        public string GetEmail()
        {
            return Email;
        }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public DateTime GetHorarioCheckIn()
        {
            return HorarioCheckIn;
        }

        public void SetHorarioCheckIn(DateTime horarioCheckIn)
        {
            HorarioCheckIn = horarioCheckIn;
        }

        public DateTime GetHorarioCheckOut()
        {
            return HorarioCheckOut;
        }

        public void SetHorarioCheckOut(DateTime horarioCheckOut)
        {
            HorarioCheckOut = horarioCheckOut;
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

        public void ValidarTelefone(string telefone)
    {
        if (telefone.Length == 14)
        {
            return;
        }
        throw new ExceptionValidacoes("Número de telefone deve ter 14 caracteres!");
    }
    public void ValidarEmail(string email)
    {
        if (email.Contains("@"))
        {
            return;
        }
        throw new ExceptionValidacoes("Email deve conter @!");
    }
    }
}