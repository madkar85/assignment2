using System;
using System.Collections.Generic;
using System.Text;

namespace assignment2
{
    class Person
    {
        //privata fält generella för en person
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
    }
}
