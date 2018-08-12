using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Exceptions
{
    public class BusinessRuleException : Exception
    {
        private static string BusinessExceptionMessage => "Violation of business rule.";


        public BusinessRuleException(string businessRule) 
            : base(businessRule)
        { }

        public BusinessRuleException(string businessRule, Exception innerException) 
            : base(businessRule, innerException)
        { }

        public override string Message => $"{BusinessExceptionMessage} {base.Message}";



    }
}
