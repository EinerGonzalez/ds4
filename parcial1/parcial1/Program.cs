
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar el tamaño de la matriz
            Console.Write("Ingrese un tamaño par para la matriz cuadrada (n x n): ");
            int n;
            do
            {
                Console.Write("Ingrese un tamaño par para la matriz cuadrada (n x n): ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n % 2 != 0);

            int[,] matriz = new int[n, n];

            
            Random random = new Random();

            // Variable para la suma
            int numerosDentro = 0;

            // llena con valores 1y 100
            for (int i = 1; i < n - 1; i++)
            {
                for (int j = 1; j < n -1 ; j++)
                {
                    int valorcualquiera = random.Next(1, 100);
                    matriz[i, j] = valorcualquiera;
                    numerosDentro += valorcualquiera;
                }
            }

            // Imprimir la matriz
            Console.WriteLine("La matriz cuadrada con borde de ceros y centro aleatorio entre 1 y 100 es:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matriz[i, j] + " " + " ");
                }
                Console.WriteLine();
            }

            // Imprimir la suma de los valores interiores
            Console.WriteLine($"La suma de los valores dentro de la matriz es: {numerosDentro}");
        }
    }
