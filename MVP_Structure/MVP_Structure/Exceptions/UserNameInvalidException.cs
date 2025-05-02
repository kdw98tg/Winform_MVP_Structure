namespace MVP_Structure.Exceptions
{
    class UserNameInvalidException : Exception
    {
        public UserNameInvalidException()
        {

        }

        public UserNameInvalidException(string _message) : base(_message)
        {

        }

        public UserNameInvalidException(string _message, Exception _inner) : base(_message, _inner)
        {

        }
    }
}