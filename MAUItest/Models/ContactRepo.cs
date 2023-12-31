﻿using System;
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
			var contact = _contacts.FirstOrDefault(x => x.ContactId == contactId);
			if (contact != null)
			{
				return new Contact
				{
					ContactId = contact.ContactId,
					Name = contact.Name,
					Email = contact.Email,
					PhoneNum = contact.PhoneNum
				};
			}
			return null;
		}

		public static void UpdateContact(int contactId, Contact contact)
		{
			if (contactId != contact.ContactId) return;

            var contactToUpdate = _contacts.FirstOrDefault(x => x.ContactId == contactId);
			if (contactToUpdate != null)
			{
                contactToUpdate.Email = contact.Email;
                contactToUpdate.Name = contact.Name;
                contactToUpdate.PhoneNum = contact.PhoneNum;
            }
		}

		public static void AddContact(Contact contact)
		{
			var maxId = _contacts.Max(x => x.ContactId);
			contact.ContactId = maxId + 1;
			_contacts.Add(contact);
		}

		public static void DeleteContact(int contactId)
		{
			var contact = _contacts.FirstOrDefault(x => x.ContactId == contactId);
			if (contact != null)
			{
				_contacts.Remove(contact);
			}
		}
	}
}

