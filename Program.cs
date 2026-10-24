Console.WriteLine("---Análise de Crédito--");

Console.WriteLine("Digite o valor do empréstimo desejado");
decimal valordesejado =  Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Digite em quantas parcelas deseja pagar:");
int qtparcelas = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Informe sua renda mensal COMPROVADA: ");
decimal rendamensal = Convert.ToDecimal(Console.ReadLine());

decimal valorparcela = valordesejado / qtparcelas; 
decimal maiorparcelaautorizada = rendamensal / 100 * 30;

Console.WriteLine();

Console.WriteLine($"O valor da parcela é:{valorparcela:C}.");
Console.WriteLine($"O valor da sua maior parcela permitida é de {maiorparcelaautorizada:C}.");

Console.WriteLine();

if (valorparcela > maiorparcelaautorizada)
{
   Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Seu empréstimo não foi autorizado.");
    Console.ResetColor();
}

else 
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Seu empréstimo foi autorizado");
    Console.ResetColor();
}