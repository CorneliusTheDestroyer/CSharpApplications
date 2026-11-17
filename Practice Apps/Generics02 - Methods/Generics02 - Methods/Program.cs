namespace Generics02___Methods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Box<string> boxStr = new Box<string>("Message01");
            boxStr.UpdateContent("Message02");
            Console.WriteLine(boxStr.GetContent());
        }
    }
}
