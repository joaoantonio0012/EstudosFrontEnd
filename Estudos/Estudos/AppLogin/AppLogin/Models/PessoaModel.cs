using System;
using System.Collections.Generic;
using System.Text;

namespace AppLogin.Models
{
        public class PessoaModel : EntidadeModel
    {
        public bool Ativo { get; set; }
        public string Observacoes { get; set; }
        public bool ValidoParaContrato { get; set; }
        #region Dados especificos da pessoa
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public int? ProfissaoId { get; set; }
        public string ProfissaoNome { get; set; }
        public string Rg { get; set; }
        public string RgOrgaoEmissor { get; set; }
        public int? RgEstadoEmissorId { get; set; }
        public string CpfOuCnpj { get; set; }
        public decimal? RendaFamiliarAproximada { get; set; }
        public string Creci { get; set; }
        public int? LoginId { get; set; }

        public int? PosicaoFinanceira { get; set; }
        public DateTime? DataDeNascimento { get; set; }
        public int? Sexo { get; set; }
        public bool? Investidor { get; set; }
        public bool? PossuiImovel { get; set; }
        public decimal? ImovelValor { get; set; }
        #endregion

        #region Telefones
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Telefone3 { get; set; }

        public string Celular1 { get; set; }
        public string Celular2 { get; set; }
        public string Celular3 { get; set; }
        #endregion

        #region Endereços
      //  public EnderecoModel Endereco { get; set; }

        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public string Email3 { get; set; }
        #endregion

        #region Configuracoes
        public bool PermitecontatoPorTelefone { get; set; }
        public bool PermiteContatoPorEmail { get; set; }
        public bool PermitecontatoPorWhatsApp { get; set; }

        public bool ProcuraImovelParaCompra { get; set; }
        public bool ProcuraImovelParaAlugar { get; set; }

        public bool OfereceImovelParaVenda { get; set; }
        public bool OfereceImovelParaAluguel { get; set; }

        public bool Fornecedor { get; set; }
        public bool VisivelParaTodos { get; set; } /* Criar um menu separado para estes casos na view, deixar um aviso que é uma pessoa publica */
        #endregion

        #region O que a pessoa busca
        public decimal? BuscaImovelValorMinimo { get; set; }
        public decimal? BuscaImovelValorMaximo { get; set; }

        public bool BuscaImovel { get; set; }
        public bool BuscaTerreno { get; set; }
        public bool BuscaRural { get; set; }
        public bool BuscaApenasImovelNovo { get; set; }
        #endregion

    //    public PessoaPerfilDeInteresseModel PerfilDeInteresse { get; set; }

        public string Arquivo { get; set; }

        public bool AreaDoClienteAcessoLiberado { get; set; }

        public int CanalDeEntrada { get; set; }
        public bool PossuiFgts { get; set; }

        public decimal? ValorDoFgts { get; set; }

        public bool PossuiRecursoProprio { get; set; }

        public decimal? ValorDoRecursoProprio { get; set; }

        public bool UltilizarRecursoDoFinanciamentoParaDocumentacao { get; set; }

        public int ResponsavelPessoaId { get; set; }
        public string ResponsavelNomePessoa { get; set; }
        public int TipoDePessoaNoContrato { get; set; }
        public int? TipoDeEstadoCivil { get; set; }
        public string Nacionalidade { get; set; }
        public bool Imobiliaria { get; set; }
        public bool CorretorAutonomo { get; set; }
    }
}
