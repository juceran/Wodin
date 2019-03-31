using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wodin.Models.Base;

namespace Wodin.Models
{
    public class MenuLi : CamposComuns
    {
        [Column(TypeName = "varchar(128)")]
        [Display(Name = "SubMenu")]
        public string SubMenu { get; set; }

        [Column(TypeName = "varchar(256)")]
        [Display(Name = "URL")]
        public string Url { get; set; }

        [Column(TypeName = "varchar(128)")]
        [Display(Name = "Título")]
        public string Titulo { get; set; }

        //Relacionamentos   
        [Display(Name = "Menu")]
        public int MenuUlId { get; set; }
        public MenuUl MenuUl { get; set; }
    }
}
