internal class Program
{
    private static void Main(string[] args)
    {
        int numero, fat, contador;
        Console.WriteLine( " Informe o numero para o calculo: ");
        numero = int.Parse( Console.ReadLine() );
        fat = numero;
        for( contador = (numero -1); contador >= 1; contador -- )
        {
            fat *= contador;
        }

        if(numero == 0)
        {
            fat = 1;
        }
               
        Console.WriteLine($"fatorial de {numero} é : {fat}");
    }
}