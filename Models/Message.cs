
using System.ComponentModel.DataAnnotations;

namespace ChatHistoryAPI.Models
{
    public class Message
    {
        [Key]
        public Guid Id { get; set; }

        public Guid? TopicId { get; set; }
        public string Sender { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }

    }
}