using System;

namespace tpmodul5_1302223090
{
    public class HaloGeneric
    {
        public static void SapaUser<Ting>(Ting name)
        {
            Console.WriteLine("Halo User " + name + "\n");
        }
    }

    public class DataGeneric<Ting>
    {
        private Ting data { get; set; }
        public DataGeneric(Ting data)
        {
            this.data = data;
        }
        public void PrintData()
        {
            Console.WriteLine("Data Yang Tersimpan Adalah: " + data);
        }
    }
    class MainProgram
    {
        public static void Main(string[] args)
        {
            string namaPraktikkan = "Ijup";
            HaloGeneric.SapaUser(namaPraktikkan);
            DataGeneric<string> Y = new DataGeneric<string>("Y");
            Y.PrintData();
            DataGeneric<string> nim = new DataGeneric<string>("1302223090");
            nim.PrintData();
        }

    }
}
