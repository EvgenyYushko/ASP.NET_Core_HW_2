using System;

namespace FeedbackApp.Models
{
    public class MediaFile : BaseEntity
    {
        public string Path { get; set; }
        public Guid FeedbackId { get; set; }
        public virtual Feedback Feedback { get; set; }

    }
}
