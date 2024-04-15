using System;
using System.Net;

class Program
{
    static void Main()
    {
        string email = "awesome@dotnet.com";
        Console.WriteLine(EmailCensored(email));
    }
    static string EmailCensored(string mail)
    {
        string censoredEmail;
        int atSignIndex = mail.IndexOf('@');
        string usernameSubstring = mail.Substring(0, atSignIndex);
        string domainName = mail.Remove(0, atSignIndex);
        string cesonsoredUsername = new string('*', usernameSubstring.Length);
        censoredEmail = new string ($"{ cesonsoredUsername}{ domainName}");
        return censoredEmail;

    }
}