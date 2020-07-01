using System;

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

            var myBird = new Bird();
            myBird.DoesFly = true;
            myBird.FeatherColor = "yellow and red";
            myBird.IsPredator = true;

            Console.WriteLine($"My Bird is so pretty it has {myBird.FeatherColor} feathers, and is a {myBird.IsPredator} Predator. So does he fly? {myBird.DoesFly}");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var myReptile = new Reptile();

            myReptile.DoesSwim = true;
            myReptile.HasTail = true;
            myReptile.NumberOfLegs = 4;
            myReptile.HasScales = true;

            Console.WriteLine($"My Lizard is so cool! does it have a tail? {myReptile.HasTail} and it has {myReptile.NumberOfLegs} legs. So does he swim? {myReptile.DoesSwim}");



        }
    }
}
