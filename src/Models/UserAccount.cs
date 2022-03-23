using System.Security.Cryptography;

namespace PassMan.Models;

public class UserAccount
{
    public long Id { get; set; }
    public string Username { get; set; }
    private byte[] _password;
    private byte[] _salt;

    public UserAccount(long id, string username, byte[] password, byte[] salt)
    {
        Id = id;
        Username = username;
        _password = password;
        _salt = salt;
    }

    public UserAccount(long id, string username, string password)
    {
        Id = id;
        Username = username;
        SetPassword(password);
    }

    public void SetPassword(string password)
    {
        var provider = new RNGCryptoServiceProvider();
        var salt = new byte[128];
        provider.GetBytes(salt);
        _salt = salt;

        var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
        _password = pbkdf2.GetBytes(128);
    }

    public bool IsPasswordCorrect(string password)
    {
        if (_salt == null)
        {
            return false;
        }
        var pbkdf2 = new Rfc2898DeriveBytes(password, _salt, 100000);
        return _password == pbkdf2.GetBytes(128);
    }
    
}