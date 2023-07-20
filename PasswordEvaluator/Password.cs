using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneration
{
    public class Password
    {
        public int Length { get; }
        public string Value { get; set; }
        public Strength Strength;

        public Password(string value)
        {
            this.Length = value.Length;
            this.Value = value;
        }

        public void ChangePassword(string value)
        {
            if (value == Value)
            {
                return;
            }
            Value = value;
        }

        public override string ToString()
        {
            return $"Senha: {Value} - Tamanho: {Length}";
        }
    }
}
