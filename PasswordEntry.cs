using System;

namespace PassMan;

public class PasswordEntry
{
    public long Id { get; set; }
    public long OwnerId { get; set; }
    public string Website { get; set; }
    public string Username { get; set; }
    private string _password;

    public PasswordEntry(long ownerId, string website, string username, string password)
    {
        OwnerId = ownerId;
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