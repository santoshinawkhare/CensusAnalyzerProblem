using System;
using System.Collections.Generic;
using System.Text;

namespace CensusAnalyzerProblem
{
     public class IndianStateCensusCoustomeExceptionData : Exception
    {
        public enum ExceptionType
        {
           FILE_TYPE_INVALID,
            FILE_NOT_FOUND,
            FILE_DELIMETER_WRONG,
            HEADER_IS_INCORRECT
        }
        private ExceptionType type;
        public IndianStateCensusCoustomeExceptionData(ExceptionType exceptionType, string message) : base(message)
        {
            this.type = exceptionType;
        }
    }
}
