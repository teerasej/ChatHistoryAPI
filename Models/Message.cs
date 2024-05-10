using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatHistoryAPI.Models
{
   public class Message
{
    public int Id { get; set; }
    public int TopicId { get; set; }
    public string Sender { get; set; }
    public string Content { get; set; }
    public DateTime Timestamp { get; set; }
    public Topic Topic { get; set; }
}
}