using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Article
    {
        public Guid Id { get; set; }

        public DateTime DatePublished { get; set; }

        [Required]
        public string Author { get; set; } //Change to another class

        [Required]
        [StringLength(100, ErrorMessage ="Title must have less than 100 characteres")]
        public string Title { get; set; }

        [Required]
        [StringLength(200)]
        public string Description { get; set; }

        [Required]
        [StringLength(2000)]
        public string Content { get; set; }

        [Required]
        [StringLength(5000)]
        public string MainContent { get; set; }

        public string MainPhoto { get; set; }

        public string SecundaryPhoto { get; set; }

        public string Category { get; set; }

        [Required]
        [StringLength(80)]
        public string Tags { get; set; }
    }
}
