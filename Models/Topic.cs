using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatHistoryAPI.Models
{
    public class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserID { get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}