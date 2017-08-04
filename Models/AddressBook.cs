using System.Collections.Generic;

namespace AddressBook.Models
{
  public class Contact
  {
    private string _name;
    private string _phoneNumber;
    private string _address;
    private int _id;

    private static List<Contact> _contacts = new List<Contact>{};

    public Contact (string name, string phoneNumber, string address)
    {
      _name = name;
      _phoneNumber = phoneNumber;
      _address = address;
      _contacts.Add(this);
      _id = _contacts.Count;
    }

    public int GetID()
    {
      return _id;
    }

    public string GetName()
    {
      return _name;
    }

    public void GetName(string newName)
    {
      _name = newName;
    }

    public string GetPhoneNumber()
    {
      return _phoneNumber;
    }

    public void SetPhoneNumber(string newPhoneNumber)
    {
      _phoneNumber = newPhoneNumber;
    }

    public string GetAddress()
    {
      return _address;
    }

    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }

    public static List<Contact> GetAll()
    {
      return _contacts;
    }

    public static void ClearAll()
    {
      _contacts.Clear();
    }

    public void RemoveThis(Contact contact)
    {
      _contacts.Remove(contact);
    }

    public static Contact Find(int searchID)
    {
      return _contacts[searchID - 1];
    }
  }
}
