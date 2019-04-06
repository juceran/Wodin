using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wodin.Models.Base;

namespace Wodin.Models
{
    public class SubMenu : CamposComuns
    {
        [Column(TypeName = "varchar(128)")]
        [Display(Name = "SubMenu")]
        public string SubMenus { get; set; }

        [Column(TypeName = "varchar(256)")]
        [Display(Name = "Controller")]
        public string Controller { get; set; }

        [Column(TypeName = "varchar(128)")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        //Relacionamentos   
        [Display(Name = "Menu")]
        public int MenuId { get; set; }
        public Menu Menu { get; set; }
    }
}
