internal class Program
{
    private static void Main(string[] args)
    {
        string línea = default, dígitos = default;
        char primerDígito = default, últimoDígito = default;
        int suma=0;

        while(true)
        {
            Console.WriteLine("Introduce una línea de calibración: ");
            línea = Console.ReadLine();
            for(int i=0; i < línea.Length; i++)
            {
                if(char.IsNumber(línea[i]))
                    if(primerDígito == default)
                        primerDígito = línea[i];
                    else
                        últimoDígito = línea[i];
            }
            if(últimoDígito != default)
                dígitos = primerDígito.ToString() + últimoDígito.ToString();
            else
                dígitos = primerDígito.ToString() + primerDígito.ToString();
           
            suma += int.Parse(dígitos);
            dígitos = "";
            primerDígito = default;
            últimoDígito = default;

            Console.WriteLine(suma);
        }
        
    }
}
