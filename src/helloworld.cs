public class HelloWorld {
  public static void Main(string[] args) {
  	  string name = (args == null || args.Length == 0) ? "Geoffery" : args[0];
      System.Console.WriteLine($"Hello, {name}!");
  }
}

