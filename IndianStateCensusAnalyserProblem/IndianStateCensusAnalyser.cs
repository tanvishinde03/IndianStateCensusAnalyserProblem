﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndianStateCensusAnalyserProblem
{
    public class IndianStateCensusAnalyser
    {
        public class IndianStateCensusException : Exception
    {
        public enum IndianStateExceptionType
        {
            CSV_FILE_IS_INCORRECT,
            FILE_TYPE_INCORRECT
            }
        public IndianStateExceptionType indianStateExceptionType;
        public IndianStateCensusException(IndianStateExceptionType indianStateExceptionType, string message) : base(message)
        {
            this.indianStateExceptionType = indianStateExceptionType;
        }
    }
    }
}
