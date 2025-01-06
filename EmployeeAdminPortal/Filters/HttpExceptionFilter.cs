using EmployeeAdminPortal.Exceptions;
using EmployeeAdminPortal.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace EmployeeAdminPortal.Filters
{
    public class HttpExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            var exception = context.Exception;

            if (exception is NotFoundHttpException notFoundHttpException)
            {
                context.Result = new ObjectResult(new HttpErrorModel(notFoundHttpException.StatusCode, notFoundHttpException.Message, notFoundHttpException.StackTrace));
            }
            else
            {
                context.Result = new ObjectResult(new HttpErrorModel(500, "Internal Server Error", exception.StackTrace));
            }
            context.ExceptionHandled = true;
        }
    }
}
