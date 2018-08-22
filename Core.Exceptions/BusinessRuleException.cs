using System;

namespace Core.Exceptions
{
    /// <summary>
    /// <see cref="Exception"/> object for any business rule violation
    /// </summary>
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
