using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Main program (Med hjälp från chatGPT)
namespace Insectgame
{
    class Program1
    {
        static void Main(string[] args)
        {
            // Example usage
            LoneInsect loneInsect = new LoneInsect
            {
                Size = 300,
                Hitpoints = 750,
                Resistance = 200,
                Mobility = 120,
                Exoskeleton = true,
                Mandibles = true,
                Hp_Regen = true,
                ThornyLegs = true
            };
            loneInsect.SetSenses(50, 50, 50, 50);
            loneInsect.SetDamage(35, 60);
            loneInsect.ThornyLegsFunctionality();
            
            Console.WriteLine("Lone Insect Size after Thorny Legs Functionality: " + loneInsect.Size);
            Console.WriteLine("Lone Insect Senses: " + loneInsect.Senses);
            Console.WriteLine("Lone Insect Damage: " + loneInsect.Damage);
            Console.WriteLine("Lone Insect Size: " + loneInsect.Size);
            Console.WriteLine("Lone Insect Hitpoint: " + loneInsect.Hitpoints);
            Console.WriteLine("Lone Insect Resistance: " + loneInsect.Resistance);
            Console.WriteLine("Lone Insect Mobility: " + loneInsect.Mobility);
            Console.WriteLine("Lone Insect Exoskeleton: " + loneInsect.Exoskeleton);
            Console.WriteLine("Lone Insect Mandibles: " + loneInsect.Mandibles);
            Console.WriteLine("Lone Insect ThornyLegs: " + loneInsect.ThornyLegs);
            //Console.WriteLine("Hitpoints regenerated to " + loneInsect.Hitpoints);

            Queen queen = new Queen
            {
                Size = 150,
                Hitpoints = 800,
                Resistance = 200,
                Mobility = 100,
                Exoskeleton = true,
                Mandibles = true,
                Reproduction = true,
                Royal_Cry = true
            };
            queen.SetSenses(50, 50, 50, 50);
            queen.SetDamage(25, 50);
            queen.Royal_CryFunctionality();
            
            Console.WriteLine("queen Size after Royal Cry Functionality: " + queen.Size);
            Console.WriteLine("queen Senses: " + queen.Senses);
            Console.WriteLine("queen Damage: " + queen.Damage);
            Console.WriteLine("queen Size: " + queen.Size);
            Console.WriteLine("queen Hitpoint: " + queen.Hitpoints);
            Console.WriteLine("queen Resistance: " + queen.Resistance);
            Console.WriteLine("queen Mobility: " + queen.Mobility);
            Console.WriteLine("queen Exoskeleton: " + queen.Exoskeleton);
            Console.WriteLine("queen Mandibles: " + queen.Mandibles);
            Console.WriteLine("queen Reproduction: " + queen.Reproduction);
            Console.WriteLine("queen RoyalCry: " + queen.Royal_Cry);
        }
    }
}

