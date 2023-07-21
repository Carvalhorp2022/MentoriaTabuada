

int multiplicar;
int multiplicador;

Console.Write("Digite um numero: ");

multiplicar = Convert.ToInt32(Console.ReadLine());

for (multiplicador = 0; multiplicador <= 10; multiplicador++)
{
   Console.WriteLine(string.Format("{0}*{1}={2}", multiplicar, multiplicador, multiplicar*multiplicador)); 
}

Console.ReadKey();