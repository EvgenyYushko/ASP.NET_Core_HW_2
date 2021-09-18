using System;

namespace FeedbackApp.BLL.VMs.Comment
{
    public class CreateComment
    {
        public Guid UserId { get; set; }
        public string Text { get; set; }
        public Guid FeedbackId { get; set; }
    }
}
