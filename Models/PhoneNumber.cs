namespace Phonebook.Models
{
    public class PhoneNumber
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Type { get; set; }  // Personal, Work, Temporary

        public int ContactId { get; set; }
        public Contact Contact { get; set; }
    }
}
