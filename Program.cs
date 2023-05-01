internal class Program
{
    private static void Main(strings[] args)
    {
        // Exibe mensagem na tela para o usuário inserir um valor
        Console.WriteLine("Valor:");

        // Lê a entrada do usuário e armazena em uma variável
        Console.ReadLine();

        // Usa o operador ternário para verificar se o valor é maior ou igual a 10, 
        // se verdadeiro, exibe a mensagem "maior/igual a dez", caso contrário exibe "menor que dez"
        Console.WriteLine((valor >= 10) ? "maior/igual a dez" : "menor que dez");
    }
}
