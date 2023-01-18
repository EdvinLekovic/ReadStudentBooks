using ReadStudentBooks.Models;

namespace ReadStudentBooks.Dto
{
    public class CreditCardDto
    {
        public string TransactionalNumber { get; set; }
        public string Username { get; set; }
        public virtual User User { get; set; }
        public double Money { get; set; }
        public string CvvCode { get; set; }
        public long ExpirationMonth { get; set; }
        public long ExpirationYear { get; set; }
    }
}
