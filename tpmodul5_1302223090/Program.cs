using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302223090
{

    public class HaloGeneric
    {
        static void Main(string[] args)
        {
            string namaPraktikkan = "Ijup ";
            SapaUser(namaPraktikkan);
        }
        public static void SapaUser<Ting>(Ting name)
        {
            Console.WriteLine("Halo User " + name + "\n");

        }

    }
}
