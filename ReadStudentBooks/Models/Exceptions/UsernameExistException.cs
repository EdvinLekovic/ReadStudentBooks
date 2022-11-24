using Microsoft.CSharp.RuntimeBinder;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace ReadStudentBooks.Models.Exceptions
{
    public class UsernameExistException : RuntimeBinderException
    {
        public UsernameExistException() : base("Username Exist")
        {
        }
    }
}
