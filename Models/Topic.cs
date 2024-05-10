using System.ComponentModel.DataAnnotations;


namespace ChatHistoryAPI.Models
{
    public class Topic
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "ไม่ใส่ชื่อหัวข้อได้ไง")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "ชื่อไม่ควรน้อยกว่า 3 และไม่มากกว่า 100 ตัวอักษร")]
        public string Name { get; set; }
        public string UserID { get; set; }
        public ICollection<Message> Messages { get; set; } = new List<Message>();
    }
}