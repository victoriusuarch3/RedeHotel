using RedeHotel.Lib.Exceptions;

namespace RedeHotel.Lib.Models
{
    public class TiposQuartos : ModelBase
    {
        public int Id{get; set;}
        public string Nome{get; set;}
        public string Descricao{get; set;}
        public int OcupacaoMaxima{get; set;}
        public int CamaCasal{get; set;}
        public int CamaSolteiro{get; set;}
        public float Valor{get; set;}
        public DateTime DataCadastro{get; set;}
        public DateTime DataUltimaAtualizacao{get; set;}

        public TiposQuartos (int id, string nome, string descricao, int ocupacaoMaxima, int camaCasal, int camaSolteiro, float valor, DateTime dataCadastro, DateTime dataUltimaAtualizacao)
        : base (id, dataCadastro, dataUltimaAtualizacao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
            OcupacaoMaxima = ocupacaoMaxima;
            CamaCasal = camaCasal;
            CamaSolteiro = camaSolteiro;
            Valor = valor;
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

        public string GetDescricao()
        {
            return Descricao;
        }

        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }

        public int GetOcupacaoMaxima()
        {
            return OcupacaoMaxima;
        }

        public void SetOcupacaoMaxima(int ocupacaoMaxima)
        {
            OcupacaoMaxima = ocupacaoMaxima;
        }

        public int GetCamaCasal()
        {
            return CamaCasal;
        }

        public void SetCamaCasal(int camaCasal)
        {
            CamaCasal = camaCasal;
        }

        public int GetCamaSolteiro()
        {
            return CamaSolteiro;
        }

        public void SetCamaSolteiro(int camaSolteiro)
        {
            CamaSolteiro = camaSolteiro;
        }

        public float GetValor()
        {
            return Valor;
        }

        public void SetValor(float valor)
        {
            Valor = valor;
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

        public void ValidarOcupacaoMaxima(int ocupacaoMaxima)
        {
            var capacidadeMax = ((CamaCasal * 2) + (CamaSolteiro * 1));
            if (ocupacaoMaxima == capacidadeMax)
            {
                return;
            }
            throw new ExceptionValidacoes("Ocupação máxima não pode ser maior do que a quantidade de pessoas suportadas pelas camas!");
        }
    }
}