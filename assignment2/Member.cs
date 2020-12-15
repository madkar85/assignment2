using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class Member : Person
    {
        //privat fält specifikt för medlemmarna i gruppen
        private string reasonForProgramming;

        public string ReasonForProgramming { get => reasonForProgramming; set => reasonForProgramming = value; }

        //konstruktorer
        public Member()
        {

        }

        public Member(string name)
        {
            this.Name = name;
        }

        public Member(string name, string city, int age, string housing, string family, string pets, string occupation, string hobby, string favoriteFood, string favoriteMusic, 
            string reasonForProgramming)
        {
            this.Name = name;
            this.City = city;
            this.Age = age;
            this.Housing = housing;
            this.Family = family;
            this.Pets = pets;
            this.Occupation = occupation;
            this.Hobby = hobby;
            this.FavoriteFood = favoriteFood;
            this.FavoriteMusic = favoriteMusic;
            this.reasonForProgramming = reasonForProgramming;


        }

        //Override på ToString-metoden så detta skrivs ut istället
        public override string ToString()
        {
            return $"{this.Name} bor i {this.City}, är {this.Age} år och bor i en {this.Housing}. Familjen består av {this.Family}. Vad har {this.Name} för husdjur? {this.Pets}. Var tidigare {this.Occupation} och hobby är {this.Hobby}. " +
                $"Favoritmaten är {this.FavoriteFood} och favoritmusiken {this.FavoriteMusic}. Vad är {this.Name}s driv till programmering? {this.reasonForProgramming}";
        }
    }
}
