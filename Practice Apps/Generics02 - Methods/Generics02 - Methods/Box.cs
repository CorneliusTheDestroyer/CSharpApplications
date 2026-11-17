namespace Generics02___Methods
{
    internal class Box<T>
    {
        private T content;

        public Box(T initialValue)
        {
            content = initialValue;
        }

        public void UpdateContent(T newContent)
        {
            content = newContent;
            Console.WriteLine($"Updated content is {content}");
        }

        public T GetContent()
        {
            return content;
        }
    }
}
