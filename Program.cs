
namespace Lab19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olmasa 4 reqemli eded daxil edin...");
            int reqem=Convert.ToInt32(Console.ReadLine());
            bool check = false;
            int[] arr= new int[reqem];

           while(true)
            {
                for (int i = 0; i < arr.Length-1; i++)
                {
                    if (arr.Length>=1000 && arr.Length<10000)
                    {

                       check= true;
                       
                    }
                    else
                    {
                        check= false;
                    }
                   
                }
                
               
                Console.WriteLine(arr.Length);
                Console.WriteLine(check);

                break;
            }
        }
    }
}