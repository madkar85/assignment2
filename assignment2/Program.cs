﻿using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security;

namespace assignment2
{
    class Program
    {

        private static List<Member> membersOfTheGroup = new List<Member>();

        static void Main(string[] args)
        {
           //Lägg till en metod som lägger till datan i listan
            membersOfTheGroup.Add(new Member("Madeleine Karlsson", "Stockholm", 35, "villa", "sambo och dotter", "Tre katter", "testare", "bakning och spela Stardew Valley", 
                "biff, bea occh sötpotatis", "allt som inte är barnvisor", "Har alltid tyckt att det är intressant hur system är uppbyggda och hur de skapas, så nu vill jag kunna göra det själv"));
            membersOfTheGroup.Add(new Member("Mikael Alexander Larsson", "Vänersborg", 36, "villa", "fru, två döttrar och en tredje på väg", "Två kaniner",
                "restauranglärare", "träning och hälsa, och surdegsbröd", "bönchiligryta i tortillabröd", "elektroniskt", 
                "Den dagliga härngympan man får med programmering, det är kreativt och att man faktiskt skapar en produkt i slutändan"));
            membersOfTheGroup.Add(new Member("Sammy On Tat Wong", "Åmal", 54, "villa", "fru och son", "Tre katter och en hund",
                "personlig assistent", "fotografering och matlagning", "asiatiskt, italienskt och svensk husmanskost", "soul, RnB, house", 
                "Att kunna skapa någonting själv, problemlösning och tillfredställelse när man löst ett problem"));
            membersOfTheGroup.Add(new Member("David Josef Frödin", "Sundbyberg", 25, "lägenhet", "det vanliga", "Inga", "verksamhetschef på en studentförening",
                "leta efter universums hemligheter, målning, lära sig språk", "bortsch", "allt! Inne i en rockperiod som varvas med rysk folkmusik",
                "Det är ballt och jag får kombinera kreativitet, problemlösning och människoperspektiv i en trevlig mix"));
            membersOfTheGroup.Add(new Member("Rauf Karimli", "Göteborg", 36, "villa", "fru, en son och en dotter", "Inga", "projektledare", "spela piano och laga mat",
                "grillat kött", "gott och blandat", "De gränslösa möjligheterna att utveckla och utvecklas"));
            membersOfTheGroup.Add(new Member("Erik Rindlert", "Stockholm", 31, "lägenhet", "han själv, är ogift", "Inga", "IT-support", "litteratur och datorspel", "svensk-fransk fisksoppa",
                "Schubert eller Darkthrone, beroende på dag", "Bygga, bygga, bygga"));
            membersOfTheGroup.Add(new Member("Daniel Jacob Arlbring", "Alingsås", 24, "lägenhet", "sambo", "Inga", "väktare", "motorsport och datorspel", "italienskt", "house", ""));
            membersOfTheGroup.Add(new Member("Svante Joelsson", "Strömstad", 36, "lägenhet", "sambo och en son", "Hund", "fritidspedagog/förskolelärare", "illustrera och animera", "pasta al fungi",
                "gubbrock och allt som är bra", "Kul kombo av problemlösning och kreativitet, och att en dag landa ett jobb med mer frihet"));
            membersOfTheGroup.Add(new Member("Sarah Winroth", "Vara", 31, "lägenhet", "man", "Inga", "reseledare", "motionera gärna", "älskar mat i alla former", "det mesta",
                "Själva problemlösningen och tillfredsställelsen efteråt!"));
            membersOfTheGroup.Add(new Member("Farzane Zafarzade", "Karlstad", 32, "lägenhet", "man och inga barn", "Inga", "IT-support", "träning och bakning", "alla typer av pastarätter",
                "lugn och klassisk musik", "Problemlösning, genom att lösa problem lär man sig att bli mer tålmodig och kreativ"));



            StartPage(membersOfTheGroup);
        }


        //Startar programmet och ber om en kod. Vid fel kod stängs programmet
        public static void StartPage(List<Member> membersOfTheGroup)
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
                Menu(membersOfTheGroup);
            }

        }

        //Kollar om koden är rätt. Valde att inte göra det ok med liten bokstav i början för att det ska vara som ett vanligt lösenord
        public static bool ValidateCode(string answer)
        {
            return answer == "Coffeencode";          
        }

        //Skriver ut en meny och ger tre val. Alla valen skickar vidare till olika metoder.
        public static void Menu(List<Member> membersOfTheGroup)
        {

            bool keepGoing = true;

            Console.WriteLine("Korrekt kod. Välkommen till gruppen Coffee n Code");

            while (keepGoing)
            {
                Console.WriteLine("Vad vill du göra?");
                Console.WriteLine("1. Skriv ut alla personer i gruppen");
                Console.WriteLine("2. Skriv ut generell information om en person");
                Console.WriteLine("3. Ta bort en person ur listan");
                Console.WriteLine("Tryck q för att avsluta.");
                string answer = Console.ReadLine();
                Console.Clear();

                switch (answer)
                {
                    case "1":
                        PrintAllMembers(membersOfTheGroup);
                        break;
                    case "2":
                        PrintInformationAboutMember(membersOfTheGroup);
                        break;
                    case "3":
                        RemoveMemberFromList(membersOfTheGroup);
                        break;
                    case "q":
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("Fel input.");
                        break;
     
                }
            }
        }

        public static void PrintAllMembers(List<Member> membersOfTheGroup)
        {
            //Skriver ut alla medlemmar i gruppen
            
            foreach (Member member in membersOfTheGroup)
            {
                 Console.Write($"{member.Name}, ");
            }
            Console.WriteLine("");
        }

        public static void PrintInformationAboutMember(List<Member> membersOfTheGroup)
        {
            //Användaren får först välja vem de vill veta mer om, sedan skrivs den personens information ut.
            Console.WriteLine("Vem vill du veta mer om?");

            //skriver ut medlemmarna med sin indexsiffra, tänker att man skriver vilken siffran på personen i fråga då.
            for (int i = 0; i < membersOfTheGroup.Count; i++)
            {

                Console.WriteLine($"{i + 1}. {membersOfTheGroup[i].Name}");
            }

            int answer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(membersOfTheGroup[answer - 1]);
        }

        public static void RemoveMemberFromList(List<Member> membersOfTheGroup)
        {
            //Användaren väljer vem som ska tas bort
            Console.WriteLine("Vem vill du ta bort?");
            /*foreach (Member member in membersOfTheGroup)
            {
                Console.WriteLine(member.Name);
            }

            string answer = Console.ReadLine();*/
            for (int i = 0; i < membersOfTheGroup.Count; i++)
            {

                Console.WriteLine($"{i + 1}. {membersOfTheGroup[i].Name}");
            }

            int answer = Convert.ToInt32(Console.ReadLine());

            membersOfTheGroup.RemoveAt(answer - 1);
      

        }
    }


 }


    







