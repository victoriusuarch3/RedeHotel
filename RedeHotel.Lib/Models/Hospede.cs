namespace RedeHotel.Lib.Models
{
    public class Hospede
    {
        public int Id{get; set;}
        public string Nome{get; set;}
        public string Telefone{get; set;}
        public string Cpf{get; set;}
        public string Email{get; set;}
        public DateTime DataNascimento{get; set;}
        public DateTime DataCadastro{get; set;}
        public DateTime DataUltimaAtualizacao{get; set;}

        public Hospede (int id, string nome, string telefone, string cpf, string email, DateTime dataNascimento, DateTime dataCadastro, DateTime dataUltimaAtualizacao)
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
        public Hospede()
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
    }
}