namespace MVP_Structure.Exceptions
{
    public class UserAgeException : Exception
    {
        public UserAgeException()
        {

        }

        public UserAgeException(string _message) : base(_message)
        {

        }

        public UserAgeException(string _message, Exception _inner) : base(_message, _inner)
        {

        }
    }
}
