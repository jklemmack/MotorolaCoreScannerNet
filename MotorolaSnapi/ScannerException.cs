﻿using System;
using System.Runtime.Serialization;

namespace Motorola.Snapi
{
    [Serializable]
    public class ScannerException : Exception
    {
        private int _errorCode;
        public ScannerException() { }

        public ScannerException(string message) : base(message) { }

        public ScannerException(string message, Exception innerException) : base(message, innerException) { }

        public ScannerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
            if (info != null)
            {
                _errorCode = info.GetInt32("_errorCode");
            }
        }

        public int ErrorCode
        {
            get { return _errorCode; }
            set { _errorCode = value; }
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);

            if (info != null)
            {
                info.AddValue("_errorCode", _errorCode);
            }
        }
    }
}
