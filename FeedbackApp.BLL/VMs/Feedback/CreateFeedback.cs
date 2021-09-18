using FeedbackApp.BLL.VMs.MediaFile;
using System;
using System.Collections.Generic;

namespace FeedbackApp.BLL.VMs.Feedback
{
    public class CreateFeedback
    {
        public Guid UserId { get; set; }
        public string Text { get; set; }
        public int Rate { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public List<CreateMediaFile> MediaFiles { get; set; }
    }
}
