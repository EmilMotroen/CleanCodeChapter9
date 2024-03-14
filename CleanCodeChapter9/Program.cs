namespace CleanCodeChapter9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnvironmentController environmentController = new EnvironmentController();
            Console.WriteLine($"Controller state: {environmentController.GetState()}");
        }
    }
}
