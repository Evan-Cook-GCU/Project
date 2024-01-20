using ProjectAPI.Models.DomainModels;

namespace ProjectAPI.services
{
    public class CreateGroupServic : ICreateGroupService
    {
        //constructor
        public CreateGroupServic()
        {
            
        }
        public int Invoke(GroupModel model)
        {
            using var context = new ProjectContext();
            context.Groups.Add(model);
            context.SaveChanges();
            return model.Id;
        }
    }
}
