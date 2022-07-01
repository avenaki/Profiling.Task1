using Profiling.Task1;
using System.Text;

Console.WriteLine("");

var salt = "ksbdhfrebasdhjkd";
var saltBytes = Encoding.UTF8.GetBytes(salt);
var passwordHash = PasswordGenerator.GeneratePasswordHashUsingSalt("superSecurePassword", saltBytes);

Console.WriteLine(passwordHash);
