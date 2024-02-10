namespace StringArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("объявление строкового массива через список инициализоторов и вывод на консоль черезе foreach\n");
           
            string[] textArray = { "text", "test", "sometext" };
            Array.Sort(textArray);
            foreach (string item in textArray)
                Console.WriteLine(item);



            Console.WriteLine("\n\nобъявление и инициализация массива на 10 строк");

            string[] textArrayGenerated = new string[10];
            Console.WriteLine("введите символ для генерации строк");
            char symbol = (char)Console.Read(); //символ на основе которого будут генерироваться строки

            for(int i = 0; i< textArrayGenerated.Length; i++ )
            {
                textArrayGenerated[i] = new String(symbol, i);
                
                //вывести только те строки, длина которых нечетная
                if (!(textArrayGenerated[i].Length % 2 == 0))
                    Console.WriteLine($"i = {i} строка:\t {textArrayGenerated[i]}");
            }

            
        }
    }
}
