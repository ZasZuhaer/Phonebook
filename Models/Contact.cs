public class Contact
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string Group { get; set; }
    public string? ProfilePhotoPath { get; set; }

    public ICollection<PhoneNumber> PhoneNumbers { get; set; }
}
