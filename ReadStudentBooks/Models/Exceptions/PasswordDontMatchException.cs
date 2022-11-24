using Microsoft.CSharp.RuntimeBinder;

namespace ReadStudentBooks.Models.Exceptions
{
    public class PasswordDontMatchException : RuntimeBinderException
    {
        public PasswordDontMatchException() : base("Passwords don't match")
        {
        }
    }
}
