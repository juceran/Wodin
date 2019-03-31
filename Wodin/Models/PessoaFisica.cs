using Wodin.Models.Base;
using Wodin.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wodin.Models
{
    public class PessoaFisica : CamposComuns
    {
        [Required]
        [DefaultValue(false)]
        [Display(Name = "Física")]
        public bool Fisica { get; set; }

        [Column(TypeName = "varchar(128)")]
        public string Nome { get; set; }

        [Column(TypeName = "varchar(128)")]
        public string Pai { get; set; }

        [Column(TypeName = "varchar(128)")]
        public string Mae { get; set; }

        [Column(TypeName = "varchar(16)")]
        public string CPF { get; set; }

        [Column(TypeName = "varchar(64)")]
        public string RG { get; set; }

        [Column(TypeName = "Date")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime? DataNascimento { get; set; }

        //enums
        public Sexo? Sexo { get; set; }

        //referencias de relacionamentos
        public int PessoaId { get; set; }
        public virtual Pessoa Pessoa { get; set; }

    }
}

