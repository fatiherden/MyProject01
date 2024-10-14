namespace MyProject01.Models;

public class PersonViewModel
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public bool IsActive => !string.IsNullOrEmpty(Name);
}
