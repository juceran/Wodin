using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wodin.Models.Base;

namespace Wodin.Models
{
    public class Menu : CamposComuns
    {
        [Column(TypeName = "varchar(128)")]
        [Display(Name = "Menu")]
        public string Menus { get; set; }

        [Column(TypeName = "varchar(256)")]
        [Display(Name = "Controller")]
        public string Controller { get; set; }
    }
}