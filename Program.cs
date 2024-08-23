double? num1;
double? num2;

Console.WriteLine("informe o primeiro numero...");
num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Informe o segundo numero...");
num2 = Convert.ToDouble(Console.ReadLine());

double soma = Convert.ToDouble(num1 + num2);
double subtracao = Convert.ToDouble(num1 - num2);
double multiplicacao = Convert.ToDouble(num1 * num2);
double divisao = Convert.ToDouble(num1 / num2);

Console.WriteLine("O resultado da soma dos números é: " + soma);
Console.WriteLine($"O resultado da subtração dos números é: {subtracao}");
Console.WriteLine("O resultado da multiplicação dos números é: {0}", multiplicacao);
Console.WriteLine("O resultado da divisão dos números é: {0}", divisao);
