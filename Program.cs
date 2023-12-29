namespace JCD1._2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro número: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            //Antes de dividir os números, devo verificar se o segundo número é diferente de zero

            if (number2 != 0)
            {
                //Calcular o resultado da divisão

                double resultado = number1/ number2;

                //Exibir o resultado com duas casas decimais

                Console.WriteLine($"O resultado da divisão é: {resultado:F2}");

            }
            else
            {
                //Exibir uma mensagem de erro se o segundo número for zero

                Console.WriteLine("Erro: Não é possível dividir por zero");
            }
        }
    }
}