using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class Members
    {
        private string name;
        private string city;
        private int age;
        private string housing;
        private string family;
        private string pets;
        private string occupation;
        private string hobby;
        private string favoriteFood;
        private string favoriteMusic;

        private string reasonForProgramming;

        public Members()
        {

        }

        public Members(string name)
        {
            this.name = name;
        }

        public Members(string name, string city, int age, string housing, string family, string pets, string occupation, string hobby, 
            string favoriteFood, string favoriteMusic, string reasonForProgramming)
        {
            this.name = name;
            this.city = city;
            this.age = age;
            this.housing = housing;
            this.family = family;
            this.pets = pets;
            this.occupation = occupation;
            this.hobby = hobby;
            this.favoriteFood = favoriteFood;
            this.favoriteMusic = favoriteMusic;
            this.reasonForProgramming = reasonForProgramming;
        }



        public string Name { get => name; set => name = value; }
        public string City { get => city; set => city = value; }
        public int Age { get => age; set => age = value; }
        public string Housing { get => housing; set => housing = value; }
        public string Family { get => family; set => family = value; }
        public string Pets { get => pets; set => pets = value; }
        public string Occupation { get => occupation; set => occupation = value; }
        public string Hobby { get => hobby; set => hobby = value; }
        public string FavoriteFood { get => favoriteFood; set => favoriteFood = value; }
        public string FavoriteMusic { get => favoriteMusic; set => favoriteMusic = value; }
        public string ReasonForProgramming { get => reasonForProgramming; set => reasonForProgramming = value; }
    }
}
