using System.ComponentModel.DataAnnotations;

namespace FeedbackApp.BLL.VMs.Feedback
{
    public class FeedbackVM
    {
        [Required]
        [Display(Name = "Text")]
        public string Text { get; set; }
    }
}
