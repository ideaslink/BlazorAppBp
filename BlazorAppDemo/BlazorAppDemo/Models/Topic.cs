using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppDemo.Models
{
    public class Topic
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TopicID { get; set; }

        [Required]
        public string? Title { get; set; }

        public string? Description { get; set; }
        public string? Author { get; set; }
        public DateTime PublishDate { get; set; }
        public string? Link {  get; set; }
    }
}
