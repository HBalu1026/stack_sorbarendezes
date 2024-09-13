namespace ConsoleApp1
{
    internal class Program : Exception
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>();
            var random = new Random();
            stack.Push(random.Next(1, 100));
            stack.Push(random.Next(1, 100));
            stack.Push(random.Next(1, 100));
            stack.Push(random.Next(1, 100));
            stack.Push(random.Next(1, 100));

            stack.Metod();
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }

    static class Extenction
    {
        public static void Metod(this Stack<int> stack)
        {
            List<int>  idk = new List<int>();
            int max = stack.Count;
            int j = 0;
            while (j < max)
            {
                idk.Add(stack.Pop());
                j++;
            }
            for (int i = 0; i < idk.Count; i++)
            {
                Console.WriteLine(idk[i]);
            }
            Console.WriteLine("-----------------------------------------------------------------------------------");
            idk.Sort();
            idk.Reverse();
            for (int i = 0; i < idk.Count; i++)
            {
                stack.Push(idk[i]);
            }
        }
    }
}
