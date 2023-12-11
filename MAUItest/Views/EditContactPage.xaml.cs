namespace MAUItest.Views;
using MAUItest.Models;
[QueryProperty(nameof(ContactId), "Id")]
public partial class EditContactPage : ContentPage
{
	private Contact contact;
	public EditContactPage()
	{
		InitializeComponent();
	}
	public string ContactId
	{
		set
		{
			contact = ContactRepo.GetContactById(int.Parse(value));
            if (contact != null)
			{
				entryName.Text = contact.Name;
				entryEmail.Text = contact.Email;
				entryPhone.Text = contact.PhoneNum;

            }

        }
	}

    void btnUpdate_Clicked(System.Object sender, System.EventArgs e)
    {
		contact.Name = entryName.Text;
        contact.Email = entryEmail.Text;
        contact.PhoneNum = entryPhone.Text;

		ContactRepo.UpdateContact(contact.ContactId, contact);
		Shell.Current.GoToAsync(nameof(AccountingPage));
    }
}
