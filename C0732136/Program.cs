using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0732136
{
    class Program
    {
        static void Main(string[] args)
        {
            //countryside c = new countryside();
            //c.run();
            (new learningexp()).run();

        }
    }
    class village
    {
        public bool isAstrildeHere;
        public village nextvillage;
        public village prevvillage;
        public String villagename;


    }
    class learningexp
    {
        public void run()
        {
            village toronto;
            toronto = new village();
            village a, b, c;
            toronto.villagename = "version a";
            a = toronto;
            Console.WriteLine(a.villagename);
            toronto = new village();
            toronto.villagename = "version b";
            b = toronto;
            Console.WriteLine(b.villagename);
            toronto = new village();
            toronto.villagename = "version c";
            c = toronto;
            Console.WriteLine(c.villagename);

            Console.ReadKey();

        }
    }

    class countryside
    {
        village maple;
        village toronto;
        village ajax;

        public void run()
        {
            maple = new village();
            maple.villagename = "toronto";
            maple.nextvillage = toronto;

        }

    }

}