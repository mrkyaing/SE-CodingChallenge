using CodingChallenge.Main.Lib;
namespace CodingChallenge.Main;
class Program {
    private readonly static string RETRY_KEY = "y";
    static void Main() {
        Console.WriteLine("Hello, Coding Challenge Start!!");
    RetryInitial:
        try {
            bool isNextTime = false;
            string nextTime = null;
            Console.Write("Please type digit(s):");
            string inputDigits = Console.ReadLine();
            do {
                var oldPhonePadConvertor = new OldPhonePadConvertor();
                var results = oldPhonePadConvertor.OldPhonePad(inputDigits);
                if (results.Any())
                    Console.WriteLine($"Input digits:{inputDigits}\nOutput result(s):{results}");
                Console.Write("Do you try next time?(yes:y,no:n):");
                nextTime = Console.ReadLine();
                if (RETRY_KEY.Equals(nextTime)) {
                    Console.Write("Please type digit(s):");
                    inputDigits = Console.ReadLine();
                    isNextTime = true;
                }
                else if (nextTime.Equals("n")) {
                    Console.WriteLine("Happy ending,program finished!!");
                    break;
                }
                else {
                    isNextTime = false;
                    Console.WriteLine("Oh,it will continue next time.");
                    goto RetryInitial;
                }
            } while (isNextTime);
        }
        catch (Exception ex) {
            Console.WriteLine("Oh!!Sorry,Invalid Process");
        }
    }
}
