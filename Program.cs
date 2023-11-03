// See https://aka.ms/new-console-template for more information

// 10/21/23 | Writing a barebones 'RPG' style console game to familarize myself more with C#.

// TODO:
    // Basic menu options to start game or exit.
    // Create a PLAYER class/object that will hold one or two values that will increase as the game progresses.
        // Values: EXPERIENCE, LEVEL, and ATTACK.
    // Create a system that will track the EXPERIENCE value and increase the player LEVEL based on given thresholds.
    // Create an NPC class/object that will be used against the PLAYER.

using System;

namespace DungeonGame
{
    class Player
    {
        public string Name = "Player";
        public int Level = 1, Experience = 0, HealthPoints = 5, AttackPoints = 5;
    }

    class NPC
    {
        public string Name = "NPC";
        public int Level = 1, HealthPoints = 1, AttackPoints = 5;

    }

    class Dungeon
    {
        public bool victory = true;
        // Method GenerateNPC to generate NPC stats to pair against the Player in the Battle method.

        // Method 'Battle' to perform the calculations against the Player and the randomly chosen NPC then return a victory or a loss.
        public static bool Battle(int playerAttack, int npcAttack, bool victory)
        {
            
            Console.WriteLine($"Your AttackPoints: {playerAttack}\tNPC AttackPoints: {npcAttack}");
            
            if (playerAttack > npcAttack) 
            {
                victory = true;
                Console.WriteLine("You won!");
                Console.ReadLine();
            }
            else
            {
                victory = false;
                Console.WriteLine("You lost!");
                Console.ReadLine();
            }
            return victory;
        }
    }

    public class Program
    {
        public static void Main()
        {
            // bool start = false;

            Console.WriteLine("Start Game? (Y/N)");
            var startGame = Console.ReadLine();
            if (startGame == "N")
            {
                Main();
            }
            else if (startGame == "Y")
            {
                Console.WriteLine("Starting...");
            }
            Console.WriteLine("Enter a name: ");
            string submittedName = Console.ReadLine();
            Console.WriteLine("Initializing new player...");

            Player Player1 = new Player();
            NPC Npc1 = new NPC();

            // Player1.Name = submittedName;
            // Player1.Name = submittedName;
            Console.WriteLine($"Name: {Player1.Name}\nLevel: {Player1.Level}\nHealthPoints: {Player1.HealthPoints}\nAttackPoints: {Player1.AttackPoints}\nExperience: {Player1.Experience}\n\n");
            
            Console.WriteLine("Battle? (Y/N)");
            var startBattle = Console.ReadLine();
            
            if (startBattle == "N")
            {
                Main();
            }
            else if (startBattle == "Y")
            {
                Dungeon Dungeon1 = new Dungeon();
                while (Dungeon1.victory == true)
                {
                    Dungeon.Battle(Player1.AttackPoints, Npc1.AttackPoints, Dungeon1.victory);
                }
            }
            
            Console.ReadLine();
        }
    }
}