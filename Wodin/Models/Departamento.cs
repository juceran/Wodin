using Wodin.Models.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Wodin.Models
{
    public class Departamento : CamposComuns
    {
        [Required(ErrorMessage = "Nome do departamento é obrigatório")]
        [Column(TypeName = "varchar(64)")]
        [Display(Name = "Nome do Departamento")]
        public string Nome { get; set; }

        //referencias de relacionamentos
        public Empresa Empresa { get; set; }
        [Display(Name = "Empresa")]
        public int EmpresaId { get; set; }
    }
}