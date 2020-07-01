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
            myBird.doesFly = true;
            myBird.featherColor = "yellow and red";
            myBird.isPredator = true;

            Console.WriteLine($"My Bird is so pretty it has {myBird.featherColor} feathers, and is a {myBird.isPredator} Predator. So does he fly? {myBird.doesFly}");


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var myReptile = new Reptile();

            myReptile.doesSwim = true;
            myReptile.hasTail = true;
            myReptile.numberOfLegs = 4;
            myReptile.hasScales = true;

            Console.WriteLine($"My Lizard is so cool! does it have a tail? {myReptile.hasTail} and it has {myReptile.numberOfLegs} legs. So does he swim? {myReptile.doesSwim}");



        }
    }
}
