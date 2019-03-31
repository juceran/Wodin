using System.ComponentModel.DataAnnotations;

namespace Wodin.Models.Base
{
    public class RelacionamentoEmpresa
    {
        //referencias de relacionamentos
        public Empresa Empresa { get; set; }
        [Display(Name = "Empresa")]
        public int EmpresaId { get; set; }
    }
}