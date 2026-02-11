namespace ConsoleApp56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;

            Person person = new Person();
            person.Name = "Майтапчийски";
            person.Age = 15;
            person.IntroduceYourself();
        }
    }
}
