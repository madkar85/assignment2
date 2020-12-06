using System;

namespace assignment2
{
    class Program
    {

        static void Main(string[] args)
        {
            
        }


        //Startar programmet och ber om en kod. Vid fel kod stängs programmet
        public static void StartPage()
        {
            Console.WriteLine("Välkommen! Vänligen ange en kod för att fortsätta: ");
            string answer = Console.ReadLine();
            bool isValidCode = ValidateCode(answer);
            if (!isValidCode)
            {
                Console.WriteLine("Fel kod. Vänligen försök igen senare.");
            }
            else
            {
                Menu();
            }

        }

        //Kollar om koden är rätt
        public static bool ValidateCode(string answer)
        {
            return answer == "coffeencode";          
        }

        //Skriver ut en meny och ger tre val. Alla valen skickar vidare till olika metoder.
        public static void Menu()
        {
            Console.WriteLine("Korrekt kod. Välkommen till gruppen Coffee n Code");
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("1. Skriv ut alla personer i gruppen");
            Console.WriteLine("2. Skriv ut generell information om en person");
            Console.WriteLine("3. Ta bort en person ur listan");
            string answer = Console.ReadLine();


        }




    }






}
