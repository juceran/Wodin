using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Wodin.Models.Base
{
    public class CamposComuns
    {
        //campos comuns nas tabelas
        public int Id { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool Ativo { get; set; }

        [Display(Name = "Data de Cadastro")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy hh:mm:ss}")]
        public DateTime? DataCadastro { get; set; }

        [DefaultValue("DateTime.Now")]
        [Display(Name = "Última Atualização")]
        [DataType(DataType.DateTime)]
        public DateTime? UltimaAtualizacao { get; set; }

        [Required]
        [DefaultValue(false)]
        public bool Deletado { get; set; }

        [Display(Name = "Data de Exclusão")]
        [DataType(DataType.DateTime)]
        public DateTime? DeletadoData { get; set; }

    }
}

