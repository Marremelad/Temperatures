namespace Temperatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? answer;
            int temp;
            bool isNumber;
            //HEllO
            do {
                Console.WriteLine("Ange en temperatur i grader celsius");
                
                answer = Console.ReadLine();
                isNumber = int.TryParse(answer, out temp);
                
                if (isNumber) {
                    if (temp >= 30) {
                        Console.WriteLine("Jättevarmt", Console.ForegroundColor = ConsoleColor.Red);
                    }
                    else if (temp >= 20 && temp <= 30) {
                        Console.WriteLine("Varmt", Console.ForegroundColor = ConsoleColor.Yellow);
                    }
                    else {
                        Console.WriteLine("Hösttemperatur", Console.ForegroundColor = ConsoleColor.Blue);
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                }
                
            } while (isNumber);
        }
    }
}
