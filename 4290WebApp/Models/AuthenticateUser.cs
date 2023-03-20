namespace _4290WebApp.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
    public class AuthenticationService
    {
        public static bool AuthenticateUser(string username, string password)
        {
            // TODO: Add code to validate the user's credentials against a database or other authentication provider
            // Return true if the user is authenticated, false otherwise

            var users = new List<User>
    {
        new User { Username = "user1", Password = "password1" },
        new User { Username = "user2", Password = "password2" },
        new User { Username = "user3", Password = "password3" }
    };

            var user = users.FirstOrDefault(u => u.Username == username && u.Password == password);

            return user != null;
        }
    }

}