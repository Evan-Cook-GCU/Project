using System.Drawing;

namespace ProjectAPI.Models.DomainModels
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string PhoneNumber { get; set; }
        public ImageModel ProfilePicture { get; set; }
        public int ProfilePictureId { get; set; }
        public List<GroupModel> Groups { get; set; }

        public UserModel()
        {
            Groups = new List<GroupModel>();
            //populate all the properties with default values
            Name = "test";
            Password = "test";
            Phone = "test";
            PhoneNumber = "test";
            Email = "test";
        }
    }
}
