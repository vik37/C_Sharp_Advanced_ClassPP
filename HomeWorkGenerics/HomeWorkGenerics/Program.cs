using HomeWorkGenerics.Entities;
using HomeWorkGenerics.Helpers;
using System;
using System.Reflection.PortableExecutable;

namespace HomeWorkGenerics
{
    class Program
    {
        public static PetStore<Dog> dogPdb = new PetStore<Dog>();
        public static PetStore<Cat> catPdb = new PetStore<Cat>();
        public static PetStore<Fish> fishPdb = new PetStore<Fish>();
        static void Main(string[] args)
        {
            dogPdb.printsPets(new Dog() { Name = "Djeki", Type = "BullDog", Age = 3, FavoriteFood = "People", GoodBoy = false });
            dogPdb.printsPets(new Dog() { Name = "Luna", Type = "Chipin", Age = 5, FavoriteFood = "Dry Dog Food", GoodBoy = false });
            dogPdb.printsPets(new Dog() { Name = "Kuche", Type = "Labrador", Age = 1, FavoriteFood = "Milk and Breed", GoodBoy = true });
            dogPdb.printsPets(new Dog() { Name = "Irena", Type = "Australian Sherpherd", Age = 2, FavoriteFood = "Bones", GoodBoy = true });
            dogPdb.printsPets(new Dog() { Name = "Riki", Type = "Doberman", Age = 3, 
                FavoriteFood = "Castor & Pollux Chicken & Sweet Potato Dog Food", GoodBoy = false });
            dogPdb.printsPets(new Dog() { Name = "Smocky", Type = "Chihuahua", Age = 1, FavoriteFood = "Dry Dog Food", GoodBoy = true });

            catPdb.printsPets(new Cat() { Name = "Caty",Type = "Bengal cat",Age = 1,LivesLeft = 9,Lazy = true});
            catPdb.printsPets(new Cat() { Name = "Machor", Type = "Ragamuffin Cat", Age = 6, LivesLeft = 9, Lazy = true });
            catPdb.printsPets(new Cat() { Name = "Sam", Type = "Persian cat", Age = 2, LivesLeft = 3, Lazy = false });
            catPdb.printsPets(new Cat() { Name = "Mimi", Type = "Siamese Cat", Age = 4, LivesLeft = 7, Lazy = false });

            fishPdb.printsPets(new Fish() { Name = "Tihi", Type = "Guppy", Age = 2, Color = "Gray", Size = 3.1 });
            fishPdb.printsPets(new Fish() { Name = "yellowish", Type = "Goldfish", Age = 1, Color = "Gold", Size = 2 });
            fishPdb.printsPets(new Fish() { Name = "Marko", Type = "Mandarinfish", Age = 4, Color = "blue-orange-yellow", Size = 7.8 });
            fishPdb.printsPets(new Fish() { Name = "Stana", Type = "Guppy", Age = 1, Color = "Gray", Size = 1.8 });
            fishPdb.printsPets(new Fish() { Name = "Blue", Type = "Blue Tang", Age = 1, Color = "Blue", Size = 2.3 });
            fishPdb.printsPets(new Fish() { Name = "Butcher", Type = "Piranha", Age = 6, Color = "black-gray-white", Size = 12 });

            dogPdb.PrintAll();
            catPdb.PrintAll();
            fishPdb.PrintAll();

            Console.WriteLine("============================");
            Console.WriteLine("What fish you like?");
            string buyFish = Console.ReadLine();
            fishPdb.RemovePetName(buyFish);
            Console.WriteLine("============================");

            Console.ResetColor();
            fishPdb.PrintAll();

            Console.WriteLine("============================");
            Console.WriteLine("What dog you like?");
            string buyDog = Console.ReadLine();
            dogPdb.RemovePetName(buyDog);
            Console.WriteLine("============================");
            Console.ResetColor();
            dogPdb.PrintAll();

            Console.WriteLine("============================");
            Console.WriteLine("What cat you like?");
            string buyCat = Console.ReadLine();
            dogPdb.RemovePetName(buyCat);
            Console.WriteLine("============================");
            Console.ResetColor();
            catPdb.PrintAll();
            

            Console.ReadLine();
        }
    }
}
