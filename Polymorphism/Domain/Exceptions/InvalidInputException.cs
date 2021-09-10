using System;  

namespace Polymorphism.Domain.Exceptions
{
    public class InvalidInputException: Exception  
    {  
        public InvalidInputException(String message)  
            : base(message)  
        {  
    
        }  
    }  
}
