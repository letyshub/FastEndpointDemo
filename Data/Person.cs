namespace FastEndpointsDemo;

public class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public int Age { get; set; } = 0;
    public DateTime CreatedAt { get; set; }
    public DateTime EditedAt { get; set; }
}