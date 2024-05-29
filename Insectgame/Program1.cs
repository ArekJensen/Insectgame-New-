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
                Size = 100,
                Hitpoints = 100,
                Resistance = 30,
                Mobility = 20,
                Exoskeleton = true,
                Mandibles = true,
                HpRegen = true,
                ThornyLegs = true
            };
            loneInsect.SetSenses(10, 10, 10, 20);
            loneInsect.SetDamage(15, 10);

            Console.WriteLine("Lone Insect HP Regen: " + loneInsect.SootheRegen(true));
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
            Console.WriteLine("Lone Insect HpRegen: " + loneInsect.HpRegen);
            Console.WriteLine("Lone Insect ThornyLegs: " + loneInsect.ThornyLegs);

            Queen queen = new Queen
            {
                Size = 20,
                Hitpoints = 200,
                Resistance = 60,
                Mobility = 40,
                Exoskeleton = true,
                Mandibles = true,
                Reproduction = true,
                RoyalCry = true
            };
            queen.SetSenses(25, 25, 25, 25);
            queen.SetDamage(30, 20);

            queen.RoyalCryFunctionality();
            Console.WriteLine("Queen Size after Royal Cry Functionality: " + queen.Size);
            Console.WriteLine("Queen Senses: " + queen.Senses);
            Console.WriteLine("Queen Damage: " + queen.Damage);
            Console.WriteLine("Lone Insect Size: " + queen.Size);
            Console.WriteLine("Lone Insect Hitpoint: " + queen.Hitpoints);
            Console.WriteLine("Lone Insect Resistance: " + queen.Resistance);
            Console.WriteLine("Lone Insect Mobility: " + queen.Mobility);
            Console.WriteLine("Lone Insect Exoskeleton: " + queen.Exoskeleton);
            Console.WriteLine("Lone Insect Mandibles: " + queen.Mandibles);
            Console.WriteLine("Lone Insect HpRegen: " + queen.Reproduction);
            Console.WriteLine("Lone Insect ThornyLegs: " + queen.RoyalCry);
        }
    }
}

