using System;
using System.Drawing;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var pigeon = new Birds();
            pigeon.CanFly = true;
            pigeon.CawSound = "bbbuuu";
            pigeon.EyesNum = 1;
            pigeon.Color = "Grey";
            pigeon.Name = "Pigeon";
            Console.WriteLine($"My fav bird is the {pigeon.Name}. Can it fly? {pigeon.CanFly}. it has only {pigeon.EyesNum} and is  {pigeon.Color}");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var slippy = new Reptiles();
            slippy.TailLength = 12;
            slippy.LegsNum = 4;
            slippy.IsSticky = true;
            slippy.EyeColor = "Blue";
            slippy.NumberOfToes = 1;
            slippy.Tasty = false;
            slippy.Name = "slippy";

            Console.WriteLine($"I have a pet reptile. its name is {slippy.Name}. it only has {slippy.NumberOfToes} toe and has {slippy.EyeColor} eyes. Is he tasty? {slippy.Tasty}");
        }
    }
}
