string palavraCensurada = "!@#$%#@";
string fraseDigitada, fraseCensurada;

Console.Write("Digite uma frase: ");
fraseDigitada = Console.ReadLine()!;

fraseCensurada = fraseDigitada
 .Replace("bobalhao", palavraCensurada)
 .Replace("otario", palavraCensurada)
 .Replace("bobo", palavraCensurada)
 .Replace("vacilao", palavraCensurada)
 .Replace("feio", palavraCensurada)
 .Replace("burro", palavraCensurada)
 .Replace("panaca", palavraCensurada);

 Console.WriteLine(fraseCensurada);