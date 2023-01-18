using Microsoft.CSharp.RuntimeBinder;

namespace ReadStudentBooks.Models.Exceptions
{
    public class UserDontExistException : RuntimeBinderException
    {
        public UserDontExistException() : base("User don't exist")
        {

        }
    }
}
