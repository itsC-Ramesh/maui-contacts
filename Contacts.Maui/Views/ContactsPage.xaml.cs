using Contacts.Maui.Models;

namespace Contacts.Maui.Views;

public partial class ContactsPage : ContentPage
{
    public ContactsPage()
    {
        InitializeComponent();

        var contacts = ContactRepository.GetContacts();

        listContacts.ItemsSource = contacts;
    }

    private async void ListContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        //if (listContacts.SelectedItem != null)
        //{
        //logic to navigate to edit contact page
        await Shell.Current.GoToAsync($"//{nameof(EditContactPage)}?Id={((Models.Contact)listContacts.SelectedItem).Id}");
        //}
    }

    //private void ListContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    //{
    //    listContacts.SelectedItem = null;
    //}
}