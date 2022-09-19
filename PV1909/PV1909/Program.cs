namespace PV1909
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clovek c = new Clovek();
            Politik p = new Politik();
            Svetec s = new Svetec();

            Console.WriteLine(c.Odpoved());
            Console.WriteLine(p.Odpoved());
            Console.WriteLine(s.Odpoved());

        }
    }
}