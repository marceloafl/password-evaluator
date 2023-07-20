# Password Evaluator

Este é um programa em C# para verificar a força de uma senha digitada pelo usuário. Ele utiliza uma enumeração Strength para classificar a força da senha em quatro níveis: VeryWeak, Weak, Moderate e Strong.

### Como usar

Importe o namespace PasswordGeneration para ter acesso às classes necessárias.

```using PasswordGeneration;```

Instrua o usuário a digitar a senha:

```
Console.WriteLine("Digite a senha para receber a avaliação de força");
string typedPassword = Console.ReadLine();
```

Crie um objeto da classe ClassifyPassword, passando a senha digitada pelo usuário como argumento para o construtor:

```ClassifyPassword classification = new ClassifyPassword(typedPassword);```

 Imprimir a classificação da senha usando o método ToString():

 ```Console.WriteLine("\n" + classification.ToString());```

 A classificação será exibida na tela, mostrando a senha digitada e sua força correspondente.

 
### Força da senha

A classificação da força da senha é baseada nas seguintes regras:

- VeryWeak: senhas que são compostas apenas por letras ou apenas por números.
- Weak: senhas que contêm letras e números, mas não possuem caracteres especiais.
- Moderate: senhas que têm mais de 8 caracteres, contêm pelo menos uma letra (minúscula ou maiúscula), pelo menos um número e um caractere especial.
- Strong: senhas que têm mais de 8 caracteres, contêm letras minúsculas, letras maiúsculas, números e caracteres especiais.

#### Classes Utilizadas
- Strength (Enumeração)
Uma enumeração que define os níveis de força da senha.

- Password (Classe)
Uma classe que representa uma senha e possui propriedades Length (tamanho) e Value (valor) da senha, além da propriedade Strength para armazenar a força da senha.

- ClassifyPassword (Classe)
Uma classe responsável por avaliar a força da senha e classificá-la de acordo com as regras definidas na enumeração Strength.

- CheckPassword (Classe)
Uma classe com métodos para verificar características específicas da senha, como comprimento, presença de números, letras maiúsculas, letras minúsculas e caracteres especiais.

### Notas
Esse programa realiza classificação da força da senha considerando aspectos que não devem ser considerados para todos os contextos.
