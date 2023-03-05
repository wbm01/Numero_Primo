internal class Program
{
    private static void Main(string[] args)
    {
        int numero;
        int cont = 0, primo = 0;

        Console.WriteLine("Informe um número: ");
        numero = int.Parse(Console.ReadLine());
        cont = int.Parse(numero.ToString());

        /*
        Console.WriteLine("Informe um número: ");
        numero = int.Parse(Console.ReadLine());
        
        if (numero % 2 != 0 && numero>1 || numero == 2)
                {
            Console.WriteLine("O número informado é primo.");
        }else {
            Console.WriteLine("O número informado não é primo.");
        }*/

        while (cont > 0){
        
            if(numero % cont == 0)
            {
                primo++;
            }
            cont--;
        }
        if(primo == 2)
        {
            Console.WriteLine("O número informado é primo.");
        }
        else
        {
            Console.WriteLine("O número informado não é primo.");
        }
    }
}