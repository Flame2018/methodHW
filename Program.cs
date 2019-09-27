using System;

namespace MethodsHW
{
    class Program
    {
        static void Main(string[] args)
        {
            var prog = new Program();
            prog.myfirst();

            prog.myfirst2(400,80);
            prog.myfirst2(400,30);
            prog.myfirst2(400,50);

            
        }

        public void myfirst()
        {
            Console.WriteLine("challenge accepted");
        }
        public void myfirst2(float param1f, float param2f)
        {
            var Average = param1f / param2f;
            Console.WriteLine(Average);
        }

        public void myfirst3(int[] array)
        {
            foreach(int x in array)
            {
                if(x == 7)
                {
                    Console.WriteLine(7);
                }else
                {
                    Console.WriteLine("Lucky You!");
                }
            }
        }

    }
}
