namespace RecruTask.Data;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public string City { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public Group? Group { get; set; }

}
