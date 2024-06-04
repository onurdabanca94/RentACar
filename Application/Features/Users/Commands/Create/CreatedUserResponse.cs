namespace Application.Features.Users.Commands.Create;

public class CreatedUserResponse
{
    public int Id { get; set; }
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Email { get; set; }
    public bool Status { get; set; }

    public CreatedUserResponse()
    {
        Firstname = string.Empty;
        Lastname = string.Empty;
        Email = string.Empty;
    }

    public CreatedUserResponse(int id, string firstName, string lastName, string email, bool status)
    {
        Id = id;
        Firstname = firstName;
        Lastname = lastName;
        Email = email;
        Status = status;
    }
}