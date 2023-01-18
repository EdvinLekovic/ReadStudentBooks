using ReadStudentBooks.Dto;
using ReadStudentBooks.Models;

namespace ReadStudentBooks.Repository
{
    public interface ICreditCardRepository
    {
        public CreditCard AddCreditCard(CreditCardDto creditCardDto);
        public void DeleteCreditCard(TransactionalNumberDto transactionalNumberDto);
        public CreditCard BuyBook(BuyBookDto buyBookDto);
        public IQueryable<CreditCard> GetCreditCardsByUsername(string username);
    }
}
