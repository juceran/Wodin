using Wodin.Models.Base;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wodin.Models
{
    public class Pessoa : CamposComuns
    {
        [Column(TypeName = "varchar(64)")]
        [MinLength(3, ErrorMessage = "Nome deve ter pelo menos 3 caracteres")]
        [Required(ErrorMessage = "Descrição é um campo obrigatório")]
        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        //referencias de relacionamentos
        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }

        //relacionamento entre pessoas   
        public PessoaCliente PessoaCliente { get; set; }
        public ICollection<PessoaEmail> PessoaEmail { get; set; } = new List<PessoaEmail>();
        public ICollection<PessoaEndereco> PessoaEndereco { get; set; } = new List<PessoaEndereco>();
        public PessoaFisica PessoaFisica { get; set; }
        public PessoaFornecedor PessoaFornecedor { get; set; }
        public PessoaJuridica PessoaJuridica { get; set; }
        public ICollection<PessoaTelefone> PessoaTelefone { get; set; } = new List<PessoaTelefone>();
        public PessoaUsuario PessoaUsuario { get; set; }
        public UsuarioPermissaoAcesso UsuarioPermissaoAcesso { get; set; }

    }
}

