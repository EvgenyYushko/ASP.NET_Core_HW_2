using FeedbackApp.BLL.VMs.Comment;
using System;
using System.Collections.Generic;

namespace FeedbackApp.BLL.VMs.Feedback
{
    public class InfoFeedback
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public string AuthorName { get; set; }
        public string Text { get; set; }
        public int Rate { get; set; }
        public string ProductName { get; set; }
        public List<InfoComment> Comments { get; set; } = new List<InfoComment>();
    }
}
