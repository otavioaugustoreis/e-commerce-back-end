using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro.Application.Return 
{
    public  class Result<T>
    {
        public bool IsSuccess { get; private set; }
        public string ErrorMessage { get; private set; }
        public T Value { get; private set; }
        public string  SuccessMessage { get; private set; }

        public Result(bool isSuccess, T value, string errorMessage, string successMessage)
        {
            IsSuccess = isSuccess;
            ErrorMessage = errorMessage;
            Value = value;
            SuccessMessage = successMessage;
        }



        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }

        public static Result<T> Success(T value, string message = "") => new(true, value, null, message);
        public static Result<T> Failure(string errorMessage) => new(false, default, errorMessage, default);
    }
}
