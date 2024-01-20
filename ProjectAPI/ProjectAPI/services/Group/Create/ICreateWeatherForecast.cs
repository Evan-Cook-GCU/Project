namespace ProjectAPI.services
{
    public interface ICreateGroupService
    {
        int Invoke(Models.DomainModels.GroupModel model);
    }
}