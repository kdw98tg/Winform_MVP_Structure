namespace MVP_Structure.Exceptions
{
    class UserNameException : Exception
    {
        public UserNameException()
        {

        }

        public UserNameException(string _message) : base(_message)
        {

        }

        public UserNameException(string _message, Exception _inner) : base(_message, _inner)
        {

        }
    }
}
