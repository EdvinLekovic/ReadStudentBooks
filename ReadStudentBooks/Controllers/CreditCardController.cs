using Microsoft.AspNetCore.Mvc;
using ReadStudentBooks.Dto;
using ReadStudentBooks.Models;
using ReadStudentBooks.Repository;

namespace ReadStudentBooks.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardController : ControllerBase
    {
        public readonly ICreditCardRepository creditCardRepository;

        public CreditCardController(ICreditCardRepository creditCardRepository)
        {
            this.creditCardRepository = creditCardRepository;
        }

        [HttpGet("{username}")]
        public IQueryable<CreditCard> GetCreditCardsByUsername([FromQuery] string username)
        {
            return creditCardRepository.GetCreditCardsByUsername(username);
        }

        [HttpPost("add-credit-card")]
        public CreditCard AddCreditCard(CreditCardDto creditCardDto)
        {
            return creditCardRepository.AddCreditCard(creditCardDto);
        }

        [HttpPost("buy-book")]
        public CreditCard BuyBook(BuyBookDto buyBookDto)
        {
            return creditCardRepository.BuyBook(buyBookDto);
        }

        [HttpPost("delete-credit-card")]
        public void DeleteCreditCard(TransactionalNumberDto transactionalNumberDto) 
        {
            creditCardRepository.DeleteCreditCard(transactionalNumberDto);
        }
    }
}
