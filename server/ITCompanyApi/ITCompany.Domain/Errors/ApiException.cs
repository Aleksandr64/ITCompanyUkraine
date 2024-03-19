namespace ITCompany.Domain;

public class ApiException : Exception
{
    public object Data { get; private set; }
    public int Status { get; private set; }

    public ApiException(string message, object data, int status): base(message)
    {
        Data = data;
        Status = status;
    }
}