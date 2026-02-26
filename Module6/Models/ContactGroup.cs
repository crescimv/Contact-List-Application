using Contact = Module6.Models.Contact;

public class ContactGroup : List<Contact>
{
    public string Key { get; set; }
    public ContactGroup(string key, List<Contact> contacts) : base(contacts)
    {
        Key = key;
    }
}