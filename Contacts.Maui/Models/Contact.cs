using System.ComponentModel.DataAnnotations;

namespace Contacts.Maui.Models;

public class Contact
{
    public int Id { get; set; }
    public required string Name { get; set; }
    [EmailAddress]
    public required string Email { get; set; }
    public string? Phone { get; set; }
    public string? Address { get; set; }
}