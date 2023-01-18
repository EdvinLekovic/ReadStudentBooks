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
        public string Description { get; set; } 
        public byte[] Content { get; set; }

        public byte[] Image { get; set; }
        public DateTime DatePublished { get; set; }
        public  List<User> Users { get; set; }

        public long Price { get; set; }

        public Book(
            string title, 
            string author, 
            string description, 
            byte[] content,
            byte[] image,
            long price)
        {
            Title = title;
            Author = author;
            Description = description;
            Content = content;
            Image = image;
            DatePublished = new DateTime();
            Users = new List<User>();
            Price = price;
        }
    }
}
