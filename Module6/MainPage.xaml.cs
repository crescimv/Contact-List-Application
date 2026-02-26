using System.Linq;
using Contact = Module6.Models.Contact;
namespace Module6
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            CollectionView.ItemsSource = GetContacts();
        }

        private List<ContactGroup> GetContacts()
        {
            var contacts = new List<Contact>
            {
                new Contact { ContactName = "Spongebob Squarepants", ContactImage = "pic1.png", PhoneNumber = "123-456-7890", Description = "Fry cook at the Krusty Krab and resident of a pineapple under the sea." },
                new Contact { ContactName = "Patrick Star", ContactImage = "pic2.png", PhoneNumber = "123-456-7890", Description = "Spongebob's best friend who lives under a rock in Bikini Bottom." },
                new Contact { ContactName = "Squidward Tentacles", ContactImage = "pic3.png", PhoneNumber = "123-456-7890", Description = "Grumpy neighbor and cashier at the Krusty Krab who dreams of being an artist." },
                new Contact { ContactName = "Sandy Cheeks", ContactImage = "pic4.png", PhoneNumber = "123-456-7890", Description = "A scientist and karate expert from Texas who lives in an air dome underwater." },
                new Contact { ContactName = "Snail Gary", ContactImage = "pic1.png", PhoneNumber = "123-456-7890", Description = "Spongebob's pet snail who meows like a cat." },
                new Contact { ContactName = "Larry Lobster", ContactImage = "pic2.png", PhoneNumber = "123-456-7890", Description = "Muscular lifeguard and regular at Goo Lagoon beach." },
                new Contact { ContactName = "Mrs Puff", ContactImage = "pic3.png", PhoneNumber = "123-456-7890", Description = "Spongebob's boating school teacher who dreads his driving attempts." },
                new Contact { ContactName = "Mr Krabs", ContactImage = "pic4.png", PhoneNumber = "123-456-7890", Description = "Mr. Krabs' teenage whale daughter who loves shopping and pop music." },
                new Contact { ContactName = "Mr Krabs", ContactImage = "pic1.png", PhoneNumber = "123-456-7890", Description = "Greedy owner of the Krusty Krab who will do anything for money." },
                new Contact { ContactName = "Plankton Sheldon", ContactImage = "pic2.png", PhoneNumber = "123-456-7890", Description = "Tiny villain who constantly schemes to steal the Krabby Patty secret formula." },
                new Contact { ContactName = "Plankton Karen", ContactImage = "pic3.png", PhoneNumber = "123-456-7890", Description = "Plankton's computer wife who is often smarter than her husband." },
                new Contact { ContactName = "Larry Fish", ContactImage = "pic4.png", PhoneNumber = "123-456-7890", Description = "A background fish resident frequently seen around Bikini Bottom." },
                new Contact { ContactName = "Mermaid Man", ContactImage = "pic1.png", PhoneNumber = "123-456-7890", Description = "Elderly retired superhero and idol of Spongebob and Patrick." },
                new Contact { ContactName = "Starnacle Boy", ContactImage = "pic2.png", PhoneNumber = "123-456-7890", Description = "Mermaid Man's sidekick who is tired of being treated like a sidekick." },
                new Contact { ContactName = "Flying Dutchman", ContactImage = "pic3.png", PhoneNumber = "123-456-7890", Description = "A ghostly pirate who haunts the seas of Bikini Bottom." }
            };

            return contacts
                .GroupBy(c => c.ContactName[0].ToString())
            .OrderBy(g => g.Key)
            .Select(g => new ContactGroup(g.Key, g.ToList()))
            .ToList();
        }

        private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Contact current = (e.CurrentSelection.FirstOrDefault() as Contact);
            await Navigation.PushAsync(new ContactDetailsPage(current));
        }

        
    }
}
