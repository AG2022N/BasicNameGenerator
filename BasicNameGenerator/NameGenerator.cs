using System;
using System.IO;

namespace BasicNameGenerator
{
    public class NameGenerator
    {
        public static string[] namesMale =   File.ReadAllLines(@"Data\\NamesMale.txt");
        public static string[] namesFemale = File.ReadAllLines(@"Data\\NamesFemale.txt");
        public static string[] lastNames =   File.ReadAllLines(@"Data\\LastNames.txt");
        public static string GenerateNameMale()
        {
            var rand = new Random();
            string randomFirstName = namesMale[rand.Next(namesMale.Length)];
            string randomLastName = lastNames[rand.Next(lastNames.Length)];
            return $"{randomFirstName} {randomLastName}";
        }
        public static string GenerateNameFemale()
        {
            var rand = new Random();
            string randomFirstName = namesFemale[rand.Next(namesFemale.Length)];
            string randomLastName = lastNames[rand.Next(lastNames.Length)];
            return $"{randomFirstName} {randomLastName}";
        }
    }
}