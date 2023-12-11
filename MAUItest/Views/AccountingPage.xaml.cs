namespace MAUItest.Views;

using System.Collections.ObjectModel;
using MAUItest.Models;


public partial class AccountingPage : ContentPage
{
	public AccountingPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();
        LoadContacts();
    }

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
    }

    async void listContacs_ItemSelected(System.Object sender, Microsoft.Maui.Controls.SelectedItemChangedEventArgs e)
    {
        if (listContacs.SelectedItem != null)
        {
            await Shell.Current.GoToAsync($"{nameof(EditContactPage)}?Id={((Contact)listContacs.SelectedItem).ContactId}");
        }
    }

    void listContacs_ItemTapped(System.Object sender, Microsoft.Maui.Controls.ItemTappedEventArgs e)
    {
        listContacs.SelectedItem = null;
    }

    void btnAdd_Clicked(System.Object sender, System.EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(DataView));
    }

    void MenuItem_Clicked(System.Object sender, System.EventArgs e)
    {
        var menuItem = sender as MenuItem;
        var contact = menuItem.CommandParameter as Contact;
        ContactRepo.DeleteContact(contact.ContactId);
        LoadContacts();
    }
    private void LoadContacts()
    {
        var contacts = new ObservableCollection<Contact>(ContactRepo.GetContacts());
        listContacs.ItemsSource = contacts;
    }
}

