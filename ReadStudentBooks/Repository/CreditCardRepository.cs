using ReadStudentBooks.Data;
using ReadStudentBooks.Dto;
using ReadStudentBooks.Models;

namespace ReadStudentBooks.Repository
{
    public class CreditCardRepository : ICreditCardRepository
    {

        public readonly ApplicationDbContext _db;

        public CreditCardRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public CreditCard AddCreditCard(CreditCardDto creditCardDto)
        {
            Random randomNumber = new Random();
            CreditCard creditCard = new CreditCard(
                creditCardDto.TransactionalNumber, 
                creditCardDto.Username, 
                randomNumber.Next(100000, 500000),
                creditCardDto.CvvCode,
                creditCardDto.ExpirationMonth,
                creditCardDto.ExpirationYear);

            _db.CreditCards.Add(creditCard);
            _db.SaveChanges();
            return creditCard;
        }

        public CreditCard BuyBook(BuyBookDto buyBookDto)
        {
            Book book = _db.Books.First(book => book.Id == buyBookDto.BookId);
            CreditCard creditCard = _db.CreditCards.First(creditCard => 
            creditCard.TransactionalNumber.Equals(buyBookDto.TransactionalNumber));
            if(creditCard.Money - book.Price > 0) 
            { 
                creditCard.Money -= book.Price;
                book.Users.Add(creditCard.User);
                _db.CreditCards.Update(creditCard);
                _db.Books.Update(book);
                _db.SaveChanges();
            }
            return creditCard;
        }

        public void DeleteCreditCard(TransactionalNumberDto transactionalNumberDto)
        {
            CreditCard creditCard = _db.CreditCards.First(creditCard => 
            creditCard.TransactionalNumber.Equals(transactionalNumberDto.TransactionalNumber));
            _db.CreditCards.Remove(creditCard);
            _db.SaveChanges();
        }

        public IQueryable<CreditCard> GetCreditCardsByUsername(string username)
        {
            return _db.CreditCards.Where(creditCard => creditCard.UsernameFK.Equals(username));
        }
    }
}
