using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReadStudentBooks.Models
{
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Title { get;  set; }
        public string Author { get; set; }
        public byte[] Content { get; set; }
        public DateTime DatePublished { get; set; }

        public Book(string title, string author, byte[] content, DateTime datePublished)
        {
            Title = title;
            Author = author;
            Content = content;
            DatePublished = datePublished;
        }
    }
}
