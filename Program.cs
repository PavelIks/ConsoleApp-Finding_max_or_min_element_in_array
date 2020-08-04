/*using System;

namespace ArrayMaxAndMin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количиство массива: ");
            int elements = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[elements];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int maxvalue = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxvalue)
                {
                    maxvalue = array[i];
                }
            }
            Console.WriteLine("Наибольший элелемент массива = {0} ", maxvalue);
            Console.ReadKey();
        }
    }
}*/

/*using System;

namespace ArrayMaxAndMin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количиство массива: ");
            int elements = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[elements];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            int minvalue = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < minvalue)
                {
                    minvalue = array[i];
                }
            }
            Console.WriteLine("Наименьший элелемент массива = {0} ", minvalue);
            Console.ReadKey();
        }
    }
}*/