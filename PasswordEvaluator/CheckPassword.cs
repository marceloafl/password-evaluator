using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PasswordGeneration
{
    public class CheckPassword
    {
        public Password Password { get; }

        public CheckPassword()
        {}

        public bool CheckMinimumEightCharacters(string password)
        {
            string regex = @".{8,}";
            return Regex.IsMatch(password, regex);
        }

        public bool CheckIfContainsNumber(string password)
        {
            string regex = @"\d";
            return Regex.IsMatch(password, regex);
        }

        public bool CheckIfContainsDowncase(string password)
        {
            string regex = "[a-z]";
            return Regex.IsMatch(password, regex);
        }

        public bool CheckIfContainsUppercase(string password)
        {
            string regex = "[A-Z]";
            return Regex.IsMatch(password, regex);
        }

        public bool CheckIfContainsSpecialCharacter(string password)
        {
            string regex = "[*@#$%^&+=]";
            return Regex.IsMatch(password, regex);
        }
    }
}
