using System;

namespace PassMan;

public class PasswordEntry
{
    public long Id { get; set; }
    public string Website { get; set; }
    public string Username { get; set; }
    private string _password;

    public PasswordEntry(long id, string website, string username, string password)
    {
        Id = id;
        Website = website;
        Username = username;
        _password = password;
    }

    public string Password
    {
        get => _password;
        set => _password = value ?? throw new ArgumentNullException(nameof(value));
    }
}