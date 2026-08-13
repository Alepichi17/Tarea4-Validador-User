namespace Tarea4_Validador_User
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("%%%% Validador de Nombre De Usuario %%%%");
            Console.WriteLine("Escribe Tu Nombre");
            string nombre = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nombre)) 
            {
                Console.WriteLine($"El Nombre No Puede Ser Vacio");
                return;
            }
            nombre = nombre.Trim();
            string nombreguardado = nombre.ToUpper();
            Console.WriteLine($"Hola {nombre} guardamos tu nombre como: {nombreguardado}");

            int numPrefijo = Math.Min(4, nombreguardado.Length);
            string Nombremail = nombreguardado.Substring(0, numPrefijo);
            Nombremail = Nombremail.ToLower();
            Console.WriteLine($"Tu correo Institucional Es: {Nombremail}@miumg.edu.gt");

            int validarnombre = nombreguardado.Length;
            bool Validar = (validarnombre >= 4 && validarnombre <=15);
            Console.WriteLine(Validar
                ? $"Usuario Aceptado"
                : $"Usuario No Valido"
                );

            int longitud = nombre.Length;
            int calc = longitud % 2;
            bool LongitudVal = (calc == 0);
            Console.WriteLine(LongitudVal
                ? $"Longitud Par"
                : $"Longitud Impar"
                );
        }
    }
}
