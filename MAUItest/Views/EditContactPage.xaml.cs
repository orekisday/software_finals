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
}
