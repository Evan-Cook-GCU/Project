namespace ProjectAPI.Models.DomainModels
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string PhoneNumber { get; set; }

        public List<Group> Groups { get; set; }

        public User()
        {
            Groups = new List<Group>();
            //populate all the properties with default values
            Name = "test";
            Password = "test";
            Phone = "test";
            PhoneNumber = "test";
            Email = "test";
        }
    }
}
