namespace Registration;

public class UserRegistration
{
    public void RegisterUser(string username, string email, string password)
    {
            
        if (string.IsNullOrWhiteSpace(username))
        {
            throw new ArgumentException("Username is required.");

        }
            
           
        if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
        {
            throw new ArgumentException("Invalid email.");
        }
            

           
        if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
        {
            throw new ArgumentException("Password must be at least 6 characters long.");
        }
            

    }   
}
