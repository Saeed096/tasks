namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int i = 1;
            while(i!= 1001)
            {
                int temp = 1;
                int counter = 0;
                while (temp != i) 
                {
                   if(i%temp == 0)
                    {
                        counter += temp;
                    }
                    temp++;
                }
                if(counter == i)
                {
                    Console.WriteLine(i);
                }
                i++;
            }
        }
    }
}
