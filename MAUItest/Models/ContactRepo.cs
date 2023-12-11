using System;
namespace MAUItest.Models
{
	public static class ContactRepo
	{
		public static List<Contact> _contacts = new List<Contact>()
		{
            new Contact { ContactId = 1, Name = "Henry Smith", Email = "test@gmail.com"},
            new Contact { ContactId = 2, Name = "John Smith", Email = "test@gmail.com"},
            new Contact { ContactId = 3, Name = "Eric Smith", Email = "test@gmail.com"}
        };
		public static List<Contact> GetContacts() => _contacts;

		public static Contact GetContactById(int contactId)
		{
			return _contacts.FirstOrDefault(x => x.ContactId == contactId);
		}
	}
}

