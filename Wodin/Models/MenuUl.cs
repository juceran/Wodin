using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Wodin.Models.Base;

namespace Wodin.Models
{
    public class MenuUl : CamposComuns
    {
        [Column(TypeName = "varchar(128)")]
        [Display(Name = "Menu")]
        public string Menu { get; set; }

        [Column(TypeName = "varchar(256)")]
        [Display(Name = "URL")]
        public string Url { get; set; }
    }
}