using System.ComponentModel.DataAnnotations;

namespace Contacts.Maui.Models;

public class Contact
{
    public int Id { get; set; }
    public required string Name { get; set; }
    [EmailAddress]
    public required string Email { get; set; }
}