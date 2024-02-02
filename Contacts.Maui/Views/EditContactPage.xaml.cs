namespace Contacts.Maui.Views;

public partial class EditContactPage : ContentPage
{
    public EditContactPage()
    {
        InitializeComponent();
    }

    private void OnCancleButtonClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync($"//{nameof(ContactsPage)}");
    }
}