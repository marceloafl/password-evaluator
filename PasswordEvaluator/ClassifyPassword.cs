using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneration
{
    public class ClassifyPassword
    {
        private string Password { get; }
        public Strength Strength { get; private set; }

        public ClassifyPassword(string password)
        {
            Password = password;
            Strength = Classify();
        }

        private Strength Classify()
        {
            CheckPassword Check = new CheckPassword();

            bool minimumLength = Check.CheckMinimumEightCharacters(Password);
            bool containsNumber = Check.CheckIfContainsNumber(Password);
            bool containsDowncase = Check.CheckIfContainsDowncase(Password);
            bool containsUppercase = Check.CheckIfContainsUppercase(Password);
            bool containsSpecialCharacter = Check.CheckIfContainsSpecialCharacter(Password);

            return SetStrength(minimumLength, containsNumber, containsDowncase, containsUppercase, containsSpecialCharacter);

        }

        private Strength SetStrength(bool minimumLength, bool containsNumber, bool containsDowncase, bool containsUppercase, bool containsSpecialCharacter)
        {
            bool veryWeak = ((containsDowncase || containsUppercase) && !containsNumber && !containsSpecialCharacter) || (!containsDowncase && !containsUppercase && containsNumber && !containsSpecialCharacter);
            bool weak = (containsDowncase || containsUppercase) && containsNumber && !containsSpecialCharacter;
            bool moderate = ((containsDowncase && !containsUppercase) || (!containsDowncase && containsUppercase)) && minimumLength && containsNumber && containsSpecialCharacter;
            bool strong = minimumLength && containsDowncase && containsUppercase && containsNumber && containsSpecialCharacter;

            if (weak)
            {
                return Strength.Weak;
            }
            else if (moderate)
            {
                return Strength.Moderate;
            }
            else if (strong)
            {
                return Strength.Strong;
            }
            else
            {
                return Strength.VeryWeak;
            }
        }

        public override string ToString()
        {
            switch (Strength)
            {
                case Strength.VeryWeak:
                    return $"Senha digitada: {Password}\nForça: Muito fraca";
                case Strength.Weak:
                    return $"Senha digitada: {Password}\nForça: Fraca";
                case Strength.Moderate:
                    return $"Senha digitada: {Password}\nForça: Moderada";
                case Strength.Strong:
                    return $"Senha digitada: {Password}\nForça: Forte";
                default:
                    return $"Senha digitada: {Password}\nForça: Muito fraca";
            }
        }


    }
}
