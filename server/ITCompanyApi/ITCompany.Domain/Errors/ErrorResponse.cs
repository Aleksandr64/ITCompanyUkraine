namespace ITCompany.Domain;

public class ErrorResponse
{
    public int StatusCode { get; set; }
    public string Name { get; set; }
    public object Errors { get; set; }
}