namespace Contacts.Maui.Models;

public static class ContactRepository
{
    #region Persisted Data

    private static readonly List<Contact> _contacts =
    [
        new() { Id = 1, Name = "Jane Kong", Email = "Jane@mail.com" },
        new() { Id = 2, Name = "Ash Grover", Email = "ash@mail.com" },
        new() { Id = 3, Name = "Peter Kevinson", Email = "peter@mail.com" },
        new() { Id = 4, Name = "John Doe", Email = "John@mail.com" },
        new() { Id = 5, Name = "Tom Cruise", Email = "tom@mail.com" },
    ];

    #endregion

    #region Query
    public static List<Contact> GetContacts() => _contacts;
    public static Contact? GetContact(int id) => _contacts.FirstOrDefault(x => x.Id == id);

    #endregion

    #region Command
    public static void RemoveContact(Contact contact) => _contacts.Remove(contact);
    public static bool UpdateContact(int id, Contact contact)
    {
        var existingContact = _contacts.FirstOrDefault(x => x.Id == id);
        if (existingContact == null) return false;
        existingContact.Name = contact.Name;
        existingContact.Email = contact.Email;
        existingContact.Phone = contact.Phone;
        existingContact.Address = contact.Address;
        return true;
    }
    public static void AddContact(Contact contact) => _contacts.Add(contact);

    #endregion
}