using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HighfieldRecruitmentTestApp.Models
{
    public class ColourDataModel
    {
        [Required]
        [DisplayName("Colour Name")]
        public string ColourName { get; set; }
        [Required]
        [DisplayName("Number of Instances in Data Set")]
        public int Quantity { get; set; }
    }
}
