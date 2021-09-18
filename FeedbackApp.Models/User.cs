using Microsoft.AspNetCore.Identity;

namespace FeedbackApp.Models
{
    public class User : IdentityUser
    {
        public int Age { get; set; }
    }
}
