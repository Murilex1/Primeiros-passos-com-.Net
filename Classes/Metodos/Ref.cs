namespace Classes.Metodos
{
    public class Red
    {
        static void Inverter(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        public static void Inverter ()
        {
            int i = 1, j = 2;
            Inverter(ref i, ref j);
            System.Console.WriteLine($" {i} e {j}");         // Escreve 1 e 2
        }
    }
}