using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HighfieldRecruitmentTestApp.Models
{
    public class AgeDataModel
    {
        [Required]
        [DisplayName("Identification Code")]
        public string id { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string firstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string lastName { get; set; }
        [Required]
        [DisplayName("Date of Birth")]
        public string dob { get; set; }
    }
}
