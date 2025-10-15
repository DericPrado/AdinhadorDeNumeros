
public class Program
{
    public static void Main(string[] args)
    {
        int numeroSecreto = new Random().Next(1, 101);
        int tentativas = 0;
        int dificuldade;
        int tentativasMaximas;
        bool acertou = false;

        Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
        Console.WriteLine("Estou pensando em um número entre 1 e 100. Adivinhe qual é!");
        Console.WriteLine("Escolha a dificuldade: (1) Fácil (2) Médio (3) Difícil");
        dificuldade = int.Parse(Console.ReadLine());
        switch (dificuldade)
        {
            case 1:
                tentativasMaximas = 10;
                break;
            case 2:
                tentativasMaximas = 5;
                break;
            case 3:
                tentativasMaximas = 3;
                break;
            default:
                tentativasMaximas = 10;
                break;
        }

        Console.WriteLine($"Você tem {tentativasMaximas} tentativas para adivinhar o número. Boa sorte!");
        
        while(tentativas < tentativasMaximas && !acertou)
        {
            Console.Write("Digite seu palpite: ");
            int palpite = int.Parse(Console.ReadLine());
            tentativas++;

            if (palpite < numeroSecreto)
            {
                Console.WriteLine($"O número é maior que {palpite}.");
            }
            else if (palpite > numeroSecreto)
            {
                Console.WriteLine($"O número é menor que {palpite}.");
            }
            else
            {
                acertou = true;
                Console.WriteLine($"Parabéns! Você adivinhou o número {numeroSecreto} em {tentativas} tentativas.");
            }
        }
    }
}