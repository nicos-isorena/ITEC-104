
namespace ISORENA_ACTIVITY5_ITEC104
{
    class Program
    {
        static void Main(string[] args)
     
        
        {
            List<int> mylist = test(new List<int>(new int[] { 10, 20, 35, 65, 48, 53, 5, 1 }));


            Console.WriteLine("10, 20, 35, 65, 48, 53, 5, 1");

            Console.WriteLine("  ");

            foreach (var i in mylist)
   
            {

                Console.Write(i.ToString() + " ");


            }
        }
        public static List<int> test(List<int> nums)
        {
            return nums.Where(n => n % 10 != 5).ToList();

        }
    }
}
