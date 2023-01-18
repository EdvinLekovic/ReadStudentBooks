using System.ComponentModel.DataAnnotations;

namespace ReadStudentBooks.Models
{
    public class CreditCard
    {
        [Key]
        public string TransactionalNumber { get; set; }
        public string UsernameFK { get; set; }
        public virtual User User { get; set; }
        public double Money { get; set; }
        public string CvvCode { get; set; }
        public long ExpirationMonth { get; set; }
        public long ExpirationYear { get; set; }

        public CreditCard(
            string transactionalNumber, 
            string usernameFK, 
            double money, 
            string cvvCode, 
            long expirationMonth, 
            long expirationYear)
        {
            TransactionalNumber = transactionalNumber;
            UsernameFK = usernameFK;
            Money = money;
            CvvCode = cvvCode;
            ExpirationMonth = expirationMonth;
            ExpirationYear = expirationYear;
        }
    }
}
