using System;

namespace assignment2
{
    class Program
    {

        static void Main(string[] args)
        {
            StartPage();
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

        //Kollar om koden är rätt. Valde att inte göra det ok med liten bokstav i början för att det ska vara som ett vanligt lösenord
        public static bool ValidateCode(string answer)
        {
            return answer == "Coffeencode";          
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

            // om svaret är 1, skicka till metod som skriver ut listan med alla personer
            // om svaret är 2, skicka till metod som ber användaren välja vilken person och sedan skriver ut denna och informationen
            // om svaret är 3, skicka till metod som ber om vilken person att ta bort och sedan tar bort denna ur listan.
        }




    }






}
