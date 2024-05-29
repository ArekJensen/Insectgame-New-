using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Insectgame
{
    // Base form class
    public class BaseForm
    {
        // Attributes
        public int Size { get; set; }
        public int Hitpoints { get; set; }
 
        // Senses attributes
        public int Eyesight { get; set; }
        public int Hearing { get; set; }
        public int Feeling { get; set; }
        public int Smell { get; set; }

        public int Blunt_Damage { get; set; }
        public int Slice_Damage { get; set; }
        public int Resistance { get; set; }
        public int Mobility { get; set; }

        // Methods (lite hjälp från google och chat)
        public virtual int SetSize() => 200;
        public virtual int SetHitpoint() => 500;
        public virtual int SetSenses(int eyesight, int hearing, int feeling, int smell)
        {
            Eyesight = eyesight;
            Hearing = hearing;
            Feeling = feeling;
            Smell = smell;
            return Senses;
        }
        // Property to get the combined senses value
        public virtual int Senses => Eyesight + Hearing + Feeling + Smell;
        
        // Sets individual damages and returns the total damage
        public virtual int SetDamage(int blunt_Damage, int slice_Damage)
        {
            Blunt_Damage = blunt_Damage;
            Slice_Damage = slice_Damage;
            return Damage;
        }

        // Property to get the combined damage value
        public int Damage => Blunt_Damage + Slice_Damage;

        public virtual int SetResistance() => 50;
        public virtual int SetMobility() => 100;
    }

    // Insect class inheriting from BaseForm
    public class Insect : BaseForm
    {
        // Attributes
        public bool Exoskeleton { get; set; }
        public bool Mandibles { get; set; }

        // Methods
        public bool SetExoskeleton() => true;
        public bool ExoskeletonFunctionality() => Exoskeleton;
        public bool SetMandibles() => true;
    }

    // Lone Insect class inheriting from Insect
    public class LoneInsect : Insect
    {
        // Attributes
        public bool Hp_Regen { get; set; }
        public bool ThornyLegs { get; set; }
        private System.Timers.Timer regenTimer;

        // Methods
        public bool SootheRegen(bool enable)
        {
            Hp_Regen = enable;
            if (Hp_Regen)
            {
                StartHealthRegeneration();
                return true;
            }
            else
            {
                StopHealthRegeneration();
            }
            return false;
        }

        private void StartHealthRegeneration()
        {
            regenTimer = new System.Timers.Timer(1000); // Set timer interval to 1 second (1000 ms)
            regenTimer.Elapsed += RegenerateHealth;
            regenTimer.AutoReset = true; // Make it repeatable
            regenTimer.Enabled = true; // Start the timer
        }

        private void StopHealthRegeneration()
        {
            if (regenTimer != null)
            {
                regenTimer.Stop();
                regenTimer.Dispose();
            }
        }

        private void RegenerateHealth(object sender, ElapsedEventArgs e)
        {
            Hitpoints += 5;
        }


        public void ThornyLegsFunctionality()
        {
            if (ThornyLegs)
            {
                Mobility += 20;
                Blunt_Damage += 10;
                Slice_Damage += 10;
            }
        }
    }

    // Queen class inheriting from Insect
    public class Queen : Insect
    {
        // Attributes
        public bool Reproduction { get; set; }
        public bool RoyalCry { get; set; }

        // Methods
        public bool SelfReproductionFunction() => Reproduction;

        public void RoyalCryFunctionality()
        {
            if (RoyalCry)
            {
                Feeling += 20;
            }
        }
    }
}
