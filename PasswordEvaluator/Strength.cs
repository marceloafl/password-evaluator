using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGeneration
{
    public enum Strength
    {
        VeryWeak, // apenas letras ou apenas números
        Weak, // letras e números
        Moderate, // mais de 8 caracteres, só letras minúsculas (ou só letras maiúsculas), número e pelo menos um caractere especial
        Strong, // mais de 8 caracteres, letra maiúscula, letra minúscula, número e pelo menos um caractere especial
    }
}
