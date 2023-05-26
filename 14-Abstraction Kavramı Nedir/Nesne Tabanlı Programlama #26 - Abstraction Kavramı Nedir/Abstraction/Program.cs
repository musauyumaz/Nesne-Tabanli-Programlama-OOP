
UserService userService = new();
IUserValidate userValidate = userService;

interface IUserValidate
{
    bool ValidateUser(UserInfo userInfo);
}

class UserService : IUserValidate
{
    public void CreateUser(UserInfo userInfo)
    {
        //...
    }
    public void RemoveUser(UserInfo userInfo)
    {
        //...
    }
    public List<User> Users { get; set; }
    public bool ValidateUser(UserInfo userInfo)
    {
        //...
        return true;
    }
}
class UserInfo
{

}
class User
{

}