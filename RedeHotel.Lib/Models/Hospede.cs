using RedeHotel.Lib.Exceptions;
namespace RedeHotel.Lib.Models
{
    public class Hospede : ModelBase
    {
        public int Id{get; set;}
        public string Nome{get; set;}
        public string Telefone{get; set;}
        public string Cpf{get; set;}
        public string Email{get; set;}
        public DateTime DataNascimento{get; set;}
        public DateTime DataCadastro{get; set;}
        public DateTime DataUltimaAtualizacao{get; set;}
        public  virtual List<EstadiasxHospedes> Estadias_x_Hospedes{get; set;}
        public virtual List<Estadia> Estadias {get; set;}

        public Hospede (int id, string nome, string telefone, string cpf, string email, DateTime dataNascimento, DateTime dataCadastro, DateTime dataUltimaAtualizacao)
        : base (id, dataCadastro, dataUltimaAtualizacao)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Cpf = cpf;
            Email = email;
            DataNascimento = dataNascimento;
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

        public string GetTelefone()
        {
            return Telefone;
        }

        public void SetTelefone(string telefone)
        {
            Telefone = telefone;
        }

        public string GetCpf()
        {
            return Cpf;
        }

        public void SetCpf(string cpf)
        {
            Cpf = cpf;
        }

        public string GetEmail()
        {
            return Email;
        }

        public void SetEmail(string email)
        {
            Email = email;
        }

        public DateTime GetDataNascimento()
        {
            return DataNascimento;
        }

        public void SetDataNascimento(DateTime dataNascimento)
        {
            DataNascimento = dataNascimento;
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

         public void ValidacaoTelefone(string telefone)
        {
            if (telefone.Length == 14)
            {
                return;
            }
            throw new ExceptionValidacoes("Número de telefone deve ter 14 caracteres!");
        }
        public void ValidacaoCpf(string cpf)
        {
            if (cpf.All(char.IsNumber))
            {
                return;
            }
            throw new ExceptionValidacoes("CPF deve conter apenas números!");
        }
        public void ValidacaoEmail(string email)
        {
            if (email.Contains("@"))
            {
                return;
            }
            throw new ExceptionValidacoes("Email deve conter @!");
        }
    }
}