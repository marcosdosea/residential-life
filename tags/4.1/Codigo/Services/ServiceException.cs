using System;

namespace Services
{
    public class ServiceException : SystemException
    {

        public ServiceException(String mensagem, Exception inner)
            : base(mensagem, inner)
        {

        }
    }
}
