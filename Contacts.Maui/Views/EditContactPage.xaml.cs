using Contacts.Maui.Models;
using Contact = Contacts.Maui.Models.Contact;

namespace Contacts.Maui.Views;

[QueryProperty(nameof(ContactId), "Id")]
public partial class EditContactPage : ContentPage
{
    private Contact? _contact;
    public EditContactPage()
    {
        InitializeComponent();
    }

    private void OnCancleButtonClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }

    public string ContactId
    {
        set
        {
            _contact = ContactRepository.GetContact(int.Parse(value));
            if (_contact != null)
            {
                entryName.Text = _contact.Name;
                entryEmail.Text = _contact.Email;
                entryPhone.Text = _contact.Phone;
                entryAddress.Text = _contact.Address;
            }
            //labelName.Text = $"Edit Contact {_contact?.Name}";
        }
    }

    private void OnSaveButtonClicked(object sender, EventArgs e)
    {

        var contact = new Contact()
        {
            Name = entryName.Text,
            Email = entryEmail.Text,
            Phone = entryPhone.Text,
            Address = entryAddress.Text
        };

        ContactRepository.UpdateContact(_contact!.Id, contact);

        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }

    //private void OnDeleteButtonClicked(object sender, EventArgs e)
    //{
    //    if (_contact != null)
    //    {
    //        ContactRepository.DeleteContact(_contact);
    //        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    //    }
    //}

}