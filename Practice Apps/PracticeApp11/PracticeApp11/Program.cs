namespace PracticeApp11
{
    // Step 1: Declare a delegate type
    delegate int MathOperation(int a, int b);

    class Program
    {
        // Step 2: Create methods that match the delegate signature
        static int Add(int x, int y) => x + y;
        static int Subtract(int x, int y) => x - y;

        static void Main(string[] args)
        {
            // Step 3: Instantiate the delegate and assign methods
            MathOperation op = Add;
            Console.WriteLine($"Add: {op(5, 3)}"); // Output: 8

            op = Subtract;
            Console.WriteLine($"Subtract: {op(5, 3)}"); // Output: 2

            // Step 4: Use delegate as a parameter
            PrintResult(10, 4, Add);
            PrintResult(10, 4, Subtract);

            // 1. Multicast Delegate (void return type required)
            Action<int, int> multiOp = (a, b) => Console.WriteLine($"Sum: {a + b}");
            multiOp += (a, b) => Console.WriteLine($"Product: {a * b}");
            Console.WriteLine("Multicast delegate output:");
            multiOp(3, 4);

            // 2. Anonymous Method
            MathOperation anonOp = delegate (int a, int b)
            {
                return a * b;
            };
            Console.WriteLine($"Anonymous multiply: {anonOp(6, 7)}");

            // 3. Lambda Expression
            MathOperation lambdaOp = (a, b) => a / b;
            Console.WriteLine($"Lambda divide: {lambdaOp(20, 5)}");
        }

        static void PrintResult(int a, int b, MathOperation operation)
        {
            int result = operation(a, b);
            Console.WriteLine($"Result: {result}");
        }
    }
}
