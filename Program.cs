namespace Temperatures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isNumber;
            string? answer;
            
            Console.WriteLine("Ange en temperatur i grader celsius");
            
            do { 
                answer = Console.ReadLine();
                isNumber = int.TryParse(answer, out int temp);

                if (!isNumber && answer != "exit") {
                    Console.WriteLine("Ange en temperatur eller skriv 'exit'");
                }
                else if (isNumber) {
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
                
            } while (isNumber || answer != "exit" );
        }
    }
}
