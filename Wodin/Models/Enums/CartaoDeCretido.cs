using System.ComponentModel.DataAnnotations;

namespace Wodin.Models.Enums
{
    public enum CartaoDeCredito : int
    {
        [Display(Name = "American Express")]
        AmericanExpress = 3,
        [Display(Name = "Hiper Card")]
        HiperCard = 4,
        [Display(Name = "Master Card")]
        MasterCard = 1,
        Visa = 2
    }
}
