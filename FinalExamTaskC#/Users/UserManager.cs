using FinalExamTaskC_.CustomerException;

namespace FinalExamTaskC_.Users;

public  static class UserManager
{

    public static List<User>users = new List<User>();

    public static void UserAdd(User user)
    {
        if(user == null)
        {
            throw new MyArgumentNullException(nameof(user),"Cannot be null");
        }
        users.Add(user);
    }

    public static void UserUpdate(User user,int id)
    {
        if(user == null)
        {
            throw new MyArgumentNullException(nameof(user), "Can not be Null");
        }
        
        var NewUser=users.Find(user=>user.Id == id);
        if(NewUser != null)
        {
            NewUser.Email = user.Email;
            NewUser.Phone= user.Phone;
            NewUser.Name= user.Name;
            NewUser.Surname= user.Surname;

        }
       


    }
    public static User GetById(int id)
    {
        var finderUser=users.Find(users=>users.Id == id);
        if(finderUser == null) {
            throw new MyNotFound404Exception("User Not found with given id");
        }
        return finderUser;
    }

    public static void UserRemove(int id)
    {
        users.RemoveAll(user=>user.Id == id);

    }


}
