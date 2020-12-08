using System;
using System.Collections.Generic;

namespace assignment2
{
    class Program
    {

        static void Main(string[] args)
        {
            List<string> membersOfTheGroup = new List<string> {"Madde" };
            List<string> informationAboutEachMember = new List<string> {"bor i Haninge" };

            StartPage(membersOfTheGroup, informationAboutEachMember);
        }


        //Startar programmet och ber om en kod. Vid fel kod stängs programmet
        public static void StartPage(List<string> membersOfTheGroup, List<string> informationAboutEachMember)
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
                Menu(membersOfTheGroup, informationAboutEachMember);
            }

        }

        //Kollar om koden är rätt. Valde att inte göra det ok med liten bokstav i början för att det ska vara som ett vanligt lösenord
        public static bool ValidateCode(string answer)
        {
            return answer == "Coffeencode";          
        }

        //Skriver ut en meny och ger tre val. Alla valen skickar vidare till olika metoder.
        public static void Menu(List<string> membersOfTheGroup, List<string> informationAboutEachMember)
        {
            Console.WriteLine("Korrekt kod. Välkommen till gruppen Coffee n Code");
            Console.WriteLine("Vad vill du göra?");
            Console.WriteLine("1. Skriv ut alla personer i gruppen");
            Console.WriteLine("2. Skriv ut generell information om en person");
            Console.WriteLine("3. Ta bort en person ur listan");
            int answer = Convert.ToInt32(Console.ReadLine());

            // om svaret är 1, skicka till metod som skriver ut listan med alla personer
            // om svaret är 2, skicka till metod som ber användaren välja vilken person och sedan skriver ut denna och informationen
            // om svaret är 3, skicka till metod som ber om vilken person att ta bort och sedan tar bort denna ur listan.
            switch (answer)
            {
                case 1:
                    PrintAllMembers(membersOfTheGroup);
                    break;
                case 2:
                    PrintInformation(membersOfTheGroup, informationAboutEachMember);
                    break;
                case 3:
                    RemovePerson(membersOfTheGroup);
                    break;
                default:
                    Console.WriteLine("Fel input.");
                    break;
            }
        }

        public static void PrintAllMembers(List<string> membersOfTheGroup)
        {
            //Skriver ut alla medlemmar i gruppen
            foreach(string index in membersOfTheGroup)
            {
                 Console.WriteLine(index);
            }

        }

        public static void PrintInformation(List<string> membersOfTheGroup, List<string> informationAboutTheGroup)
        {
            //Användaren får först välja vem de vill veta mer om, sedan skrivs den personens information ut.
            Console.WriteLine("Vem vill du veta mer om?");

            //skriver ut medlemmarna med sin indexsiffra, tänker att man skriver vilken siffran på personen i fråga då.
            for(int i = 0; i<membersOfTheGroup.Count; i++)
            {
                Console.WriteLine(i + "." + membersOfTheGroup[i]);
            }

            int answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(informationAboutTheGroup[answer]);
             
            
        }

        public static void RemovePerson(List<string> membersOfTheGroup)
        {
            //Användaren väljer vem som ska tas bort
            Console.WriteLine("Vem vill du ta bort?");
            foreach (string index in membersOfTheGroup)
            {
                Console.WriteLine(index);
            }
            string answer = Console.ReadLine();



        }
    }


 }


    







