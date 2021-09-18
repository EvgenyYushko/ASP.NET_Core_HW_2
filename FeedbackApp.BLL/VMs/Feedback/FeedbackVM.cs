using System.ComponentModel.DataAnnotations;

namespace FeedbackApp.BLL.VMs.Feedback
{
    public class FeedbackVM
    {
        [Required]
        [Display(Name = "Text")]
        public string Text { get; set; }

        [Required]
        [Display(Name = "ProductCategory")]
        public string ProductCategory { get; set; }

        [Required]
        [Display(Name = "ProductName")]
        public string ProductName { get; set; }

        [Required]
        [Display(Name = "Rate")]
        public int Rate { get; set; }
    }
}
