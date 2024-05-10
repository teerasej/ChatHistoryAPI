using System.ComponentModel.DataAnnotations;


namespace ChatHistoryAPI.Models
{
    public class Topic
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UserID { get; set; }
        public ICollection<Message> Messages { get; set; } = new List<Message>();
    }
}