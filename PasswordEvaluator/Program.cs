using PasswordGeneration;

Console.WriteLine("Digite a senha para receber a avaliação de força");
string typedPassword = Console.ReadLine();
ClassifyPassword classification = new ClassifyPassword(typedPassword);
Console.WriteLine("\n" + classification.ToString());

Console.WriteLine("\nPara ter uma senha mais forte, considere criar uma com pelo menos oito caracteres que contenha números, letras maiúsculas, minúsculas e caracteres especiais.");

