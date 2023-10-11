using Microsoft.EntityFrameworkCore;
using REST.Data;
using REST.Entities;
using REST.Interface;

namespace REST.Repastorys
{
    public class UserRepastory : IUserRepastory
    {
        private readonly AppDbContext _appDbContext;

        public UserRepastory()
        {
        }
        public UserRepastory(AppDbContext appDbContext) => _appDbContext = appDbContext;
        public async Task<Users> CreateUser(Users users)
        {
            Users users1 = new Users(); 
            users1.Name = users.Name;
            users1.Email = users.Email;
            users1.Password = users.Password;
            _appDbContext.Users.Add(users1);
            _appDbContext.SaveChanges();
            return users1;

        }
        public async Task <Users>DeleteUser(int id)
        {
            var getid = await _appDbContext.Users.FindAsync(id);
            _appDbContext.Users.Remove(getid);
            await _appDbContext.SaveChangesAsync();
            return getid;
        }


        public async Task<List<Users>> GetAllUsers()
        {
            var getall= await _appDbContext.Users.ToListAsync();
            return getall;
        }

        public async Task<Users> GetUsersById(int id)
        {
            var userid = await _appDbContext.Users.FindAsync(id);
            return userid;
        }

        public async Task<Users> UpdateUser(int id, Users users)
        {
            var userid = await _appDbContext.Users.FindAsync(id);
            userid.Name = users.Name;
            userid.Email = users.Email;
            userid.Password = users.Password;
            _appDbContext.Users.Update(userid);
            _appDbContext.SaveChanges();
            return users;
        }
        async Task<Users> IUserRepastory.DeleteUser(int id)
        {
            var idget = await _appDbContext.Users.FindAsync(id);
            _appDbContext.Users.Remove(idget);
            await _appDbContext.SaveChangesAsync();
            return idget;
        }
    }
}
