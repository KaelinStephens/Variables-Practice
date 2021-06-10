using System;

namespace Variables_project
{
    class Program
    {
        static void Main(string[] args)
        {
            string typesOfPets = "dogs";
            int numberOfDogs = 2;
            char petParentGrade = 'A';
            bool lovePets = true;
            double petWeight = 84.8;
            decimal weightToLose = 19.8M;
            Console.WriteLine("It is {0}, I love owning pets. I have many pets including {1}. I have {2} {3}. Were I to be graded on my pet parenting, I'd give myself an {4}, but not an S because one of my {5} is overweight. He weighs {6} lbs and needs to lose {7} lbs.", lovePets, typesOfPets, numberOfDogs, typesOfPets, petParentGrade, typesOfPets, petWeight, weightToLose);
        }
    }
}
