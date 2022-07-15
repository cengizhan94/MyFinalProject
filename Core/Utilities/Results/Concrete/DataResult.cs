﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstract;

namespace Core.Utilities.Results.Concrete
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data, bool succes, string message) :base(succes,message)
        {
            Data = data;
        }
        public DataResult(T data,bool success):base (success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
