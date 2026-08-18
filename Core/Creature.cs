using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    /// <summary>
    /// Creature is a basic class for all other chatacters\monsters
    /// </summary>
    public class Creature
    {
        private string name;

        public string Name
        {
            get => name;
            set => name = string.IsNullOrWhiteSpace(value) ? "Anonym" : value;
        }

        private int health;

        public int Health
        {
            get => health;
            set
            {
                health = value < 0 ? 0 : value;

                isAlive = health < 0;

            }
        }

        private int damage;

        public int Damage
        {
            get => damage;
            set => damage = value  < 0 ? 5 : value;
        }

        private int armor;

        public int Armor
        {
            get => armor;
            set => armor = value < 0 ? 0 : value;
        }

        private int lvl;

        public int Lvl
        {
            get => lvl;
            set => lvl = value < 1 ? 1 : value;
        }

        private string id;

        public string ID
        {
            //get
            //{
            //if(id == null)
            //{
            //    return GenerateID();
            //}


            //return id;

            //return id ??= GenerateID();
            //the same as
            //id = (id == null) ? GenerateID() : id;
            // ??= special operator to work with null value, if value null do what after equal sign, if not use value data

            //}
            // the same as stetment abowe.
            // => replace {}, if there is return statement it replace return word also. can be used for statement with one row
            get => id ??= GenerateID();

        }

        private bool isAlive;

        public bool IsAlive { get; set; } = true;
        
        public Creature(string name, int health, int damage, int armor)
        {
            Name = name;
            Health = health;
            Damage = damage;
            Armor = armor;
            Lvl = 1;
        }

        private static string GenerateID() => Guid.NewGuid().ToString();
        //{
        //    return Guid.NewGuid().ToString();
        //}


        /// <summary>
        /// Take Damage
        /// </summary>
        /// <param name="incomingDamage"></param>
        public void TakeDamage(int incomingDamage)
        {
            if (!IsAlive || incomingDamage < 0) return;

            int finalDamage = incomingDamage - Armor;
            if (finalDamage < 1) finalDamage = 1;

            Health -= finalDamage;
        }


        public void Heal(int amount)
        {
            if (!IsAlive || amount <= 0) return;

            Health += amount;
        }


    }
}
