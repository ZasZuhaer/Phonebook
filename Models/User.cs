namespace Phonebook.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public ICollection<Contact> Contacts { get; set; }
    }
}
