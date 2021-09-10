using System;  

namespace Data.Driven.Domain.Exceptions
{
    public class InvalidInputException: Exception  
    {  
        public InvalidInputException(String message)  
            : base(message)  
        {  
    
        }  
    }  
}
