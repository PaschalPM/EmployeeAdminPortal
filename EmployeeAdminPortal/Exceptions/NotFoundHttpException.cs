namespace EmployeeAdminPortal.Exceptions
{
    public class NotFoundHttpException(string message = "Resource not found") : HttpException(message, 404)
    {
    }
}
