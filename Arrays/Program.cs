namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[15];
            Random random = new Random();

            int summ = 0;
            int count = 0;

            /* определить сумму и количество 
               отрицательных элементов одномерного массива   */
            for (int i = 0; i< array.Length; i++) //цикл проходит по всем элементам массива
            {
                array[i] = random.Next(-99, 100); //в ячейку массива записывается рандомное значение от -99 до 99 включительно
                Console.WriteLine($"array[{i}] = {array[i]}"); //параллельный вывод значения на консоль

                if (array[i] < 0) //подсчет суммы и количества отрицательных значений
                {
                    count++;
                    summ+=array[i];
                }
            }
            Console.WriteLine($"сумма отрицательных элементов: {summ}\n" +
                $"количество отрицательных элементов: {count}");

            /* на основе предыдущего массива произвести копирование 
               отрицаительных элементов в один массив, положительных в другой */

            int[] negative = new int[count]; //размер массива для отрицательных значений определяется значением count
            int[] positive = new int[array.Length-count]; //размер массива для полложительных числел - по остаточному принципу

            Array.Sort(array); //сортировка (по умолчанию по возрастанию)

            Console.WriteLine("отрицательные элементы");
            for (int i = 0; i< count; i++)
            {
                negative[i] = array[i];
                Console.WriteLine($"negative[{i}] = {negative[i]}");
            }

            Console.WriteLine("положительные элементы");
            for (int i = 0; i < positive.Length; i++ )
            {
                positive[i] = array[count+i]; //запись положительных элементов осуществляется со сдвигом на count значение
                Console.WriteLine($"positive[{i}] = {positive[i]}");
            }
        }
    }
}
