namespace PracticeApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            
            var myDictionary = new Dictionary<string, string> {
                ["1 "] = "1 ",
                ["2 "] = "2 ",
                ["3 "] = "3 "
            };

            //myDictionary.Add("1 ", "1 ");
            //myDictionary.Add("2 ", "2 ");
            //myDictionary.Add("3 ", "3 ");

            foreach (var item in myDictionary)
            {
                Console.Write(item.Value);
            }

        }
    }
}
