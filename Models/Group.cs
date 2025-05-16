using System;
using System.Text.Json.Serialization;

namespace Schedule_for_Un.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public byte Course { get; set; }
        public string Specialty { get; set; } = null!;

        [JsonIgnore]//змінено
        public virtual ICollection<GroupLesson> GroupLessons { get; set; } = new List<GroupLesson>();
        
    }
}