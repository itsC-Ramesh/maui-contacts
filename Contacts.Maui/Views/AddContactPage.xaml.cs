namespace Contacts.Maui.Views;

public partial class AddContactPage : ContentPage
{
    public AddContactPage()
    {
        InitializeComponent();
    }

    private void OnCancleButtonClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

}