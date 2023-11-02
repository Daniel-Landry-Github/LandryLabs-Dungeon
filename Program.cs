// See https://aka.ms/new-console-template for more information

// 10/21/23 | Writing a barebones 'RPG' style console game to familarize myself more with C#.

// TODO:
    // Basic menu options to start game or exit.
    // Create a PLAYER class/object that will hold one or two values that will increase as the game progresses.
        // Values: EXPERIENCE, LEVEL, and ATTACK.
    // Create a system that will track the EXPERIENCE value and increase the player LEVEL based on given thresholds.
    // Create an NPC class/object that will be used against the PLAYER.

class Player
{
    public string Name = "Player";
    public int Level, Experience;
    public int HealthPoints = 5;
    public int AttackPoints = 5;
}

class NPC
{
    public string Name;
    public int Level, HealthPoints, AttackPoints;

}

class Dungeon
{
    // Method GenerateNPC to generate NPC stats to pair against the Player in the Battle method.
    public static class NewNPC()
    {

    }

    // Method 'Battle' to perform the calculations against the Player and the randomly chosen NPC then return a victory or a loss.
    public static string Battle(int HealthPoints, int AttackPoints)
    {
        if (HealthPoints > 0) { }
    }
}