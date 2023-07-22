namespace Delegates
{
  delegate void MyDelegate(string x);
  delegate int CalculationDelegate(int x, int y);
  internal class Program
  {
    static void Main(string[] args)
    {
      // Simple Delegate
      MyDelegate del = PrintMethod;
      del("World!");

      // Func Delegate
      Func<int, int, int> funcDelegate = AddNumsMethod;
      int result = funcDelegate(5, 10);
      Console.WriteLine($"Sum from Func: {result}");

      // Action Delegate
      Action<string> actionDelegate = PrintMethod;
      actionDelegate("This text is printed from action delegate");

      // Predicate Delegate
      Predicate<int> predicateDelegate = IsOdd;
      bool isFiveOdd = predicateDelegate(5);
      Console.WriteLine($"5 is Odd Number,this is {isFiveOdd}");

      // Anonymous Delegate
      CalculationDelegate calculationDelegate = delegate (int x, int y)
      {
        return x * y;
      };
      Console.WriteLine($"Multiplication result from anonymous Delegate: {calculationDelegate(5,7)}");
    }

    static void PrintMethod(string name)
    {
      Console.WriteLine($"Hello, {name}");
    }

    static int AddNumsMethod(int x, int y)
    {
      return x + y;
    }

    static bool IsOdd(int x)
    {
      return x % 2 == 1;
    }
  }
}