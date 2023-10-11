using REST.Entities;

namespace REST.Interface;
public interface IUserRepastory
{
    Task<List<Users>> GetAllUsers();
    Task<Users> GetUsersById(int id);
    Task<Users> CreateUser(Users users);
    Task<Users> DeleteUser(int id);
    Task<Users> UpdateUser(int id,Users users);
}
