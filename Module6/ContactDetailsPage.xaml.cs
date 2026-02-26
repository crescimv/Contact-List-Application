using Contact = Module6.Models.Contact;
namespace Module6;

public partial class ContactDetailsPage : ContentPage
{
	private Contact contact;
	public ContactDetailsPage(Contact contact)
	{
		InitializeComponent();
		this.contact = contact;
		BindingContext = contact;
	}
}