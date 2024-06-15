namespace FastEndpointsDemo;

public class CreatePersonEvent
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Age { get; set; } = 0;
}