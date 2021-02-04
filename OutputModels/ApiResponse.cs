using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SupplyChainManagement.OutputModels
{
    public class ApiResponse<T>
    {
        public int StatusCode { get; set; }
        public string ErrorMessage { get; set; }
        public T Result { get; set; }

        public ApiResponse(HttpStatusCode statusCode, T result, string errorMessage = null) {
            StatusCode = (int) statusCode;
            Result = result;
            ErrorMessage = errorMessage;
        }
    }
}
