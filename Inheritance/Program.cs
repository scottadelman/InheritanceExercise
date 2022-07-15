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
            Bird penguin = new Bird();
            penguin.doesItFly = false;
            penguin.soundItMakes = "Penguin noises";
            penguin.canItSwim = "yes I can swim";
            penguin.whatDoesItEat = "Fish";
            penguin.doesItHaveTeeth = false;

            Console.WriteLine($" I am a penguin and I eat {penguin.whatDoesItEat}, when I speak I make {penguin.soundItMakes}, you may ask if I can swim, the answer is {penguin.canItSwim}");
            Console.WriteLine();


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile turtle = new Reptile();
            turtle.canItSwim = "yes I can swim";
            turtle.likeToPlay = false;
            turtle.soundItMakes = "Turtle noise";
            turtle.numberOfLegs = 4;
            turtle.doesItHaveTeeth = false;
            Console.WriteLine($"I am a turtle and I have {turtle.numberOfLegs} legs! People think that I might have teeth but that is {turtle.doesItHaveTeeth}. I live in the water so {turtle.canItSwim}");
        }
    }
}
