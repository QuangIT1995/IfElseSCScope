internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Select all material to craft the weapon");
        int number = Convert.ToInt32(Console.ReadLine());
        //Question 16
        switch (number)
        {
            case 1:
                Console.WriteLine("Iron");
                break;
            case 2:
                Console.WriteLine("Steel");
                break;
            case 3:
                Console.WriteLine("Gold");
                break;
            case 4:
                Console.WriteLine("Diamond");
                break;
            default:
                Console.WriteLine("Select all material to craft the weapon");
                number = Convert.ToInt32(Console.ReadLine());
                break;
        }
        //Question 17
        Console.WriteLine("Select all magic element");
        number = Convert.ToInt32(Console.ReadLine());
        switch (number){
            case 1:
                Console.WriteLine("Fire");
                break;
            case 2:
                Console.WriteLine("Water");
                break;
            case 3:
                Console.WriteLine("Earth");
                break;
            case 4:
                Console.WriteLine("Air");
                break;
            default:
                Console.WriteLine("Select all magic element");
                number = Convert.ToInt32(Console.ReadLine());
                break;
        }
        //Question 18
        Console.WriteLine("Choose skill to improve character abilities");
        number = Convert.ToInt32(Console.ReadLine());
        switch (number){
            case 1:
                Console.WriteLine("Increase Attack Damage");
                break;
            case 2:
                Console.WriteLine("Increase Defense");
                break;
            case 3:
                Console.WriteLine("Increase player turn");
                break;
            case 4:
                Console.WriteLine("Increase HP");
                break;
            default:
                Console.WriteLine("Choose skill to improve character abilities");
                number = Convert.ToInt32(Console.ReadLine());
                break;
        }
        //Question 19
        Console.WriteLine("Select a puzzle solution choice");
        number = Convert.ToInt32(Console.ReadLine());
        switch (number){
            case 1:
                Console.WriteLine("Diamond Puzzle");
                break;
            case 2:
                Console.WriteLine("Pattern Puzzle");
                break;
            case 3:
                Console.WriteLine("Logic Puzzle");
                break;
            case 4:
                Console.WriteLine("Dialogue Puzzle");
                break;
            default:
                Console.WriteLine("Select a puzzle solution choice");
                number = Convert.ToInt32(Console.ReadLine());
                break;
        }
        //Question 20
        Console.WriteLine("Select to handle ingredient");
        number = Convert.ToInt32(Console.ReadLine());
        switch (number){
            case 1:
                Console.WriteLine("Herb");
                break;
            case 2:
                Console.WriteLine("Mushroom");
                break;
            case 3:
                Console.WriteLine("Flower");
                break;
            case 4:
                Console.WriteLine("Crystal");
                break;
            default:
                Console.WriteLine("Select to handle ingredient");
                number = Convert.ToInt32(Console.ReadLine());
                break;
        }
        //Question 21
        Console.WriteLine("Select to talk with NPC");
        number = Convert.ToInt32(Console.ReadLine());
        switch (number){
            case 1:
                Console.WriteLine("Talk");
                break;
            case 2:
                Console.WriteLine("Trade");
                break;
            case 3:
                Console.WriteLine("Quest");
                break;
            case 4:
                Console.WriteLine("Select to talk with NPC");
                number = Convert.ToInt32(Console.ReadLine());
                break;
        }
        //Question 22
        Console.WriteLine("Select to navigate the scenes");
        number = Convert.ToInt32(Console.ReadLine());
        switch (number){
            case 1:
                Console.WriteLine("Dungeon");
                break;
            case 2:
                Console.WriteLine("Forest");
                break;
            case 3:
                Console.WriteLine("Bandit hangout");
                break;
            case 4:
                Console.WriteLine("Castle town");
                break;
            case 5:
                Console.WriteLine("Secret laboratory");
                break;
            default:
                Console.WriteLine("Select to navigate the scenes");
                number = Convert.ToInt32(Console.ReadLine());
                break;
        }
        //Question 23
        Console.WriteLine("Select to choose the quest");
        number = Convert.ToInt32(Console.ReadLine());
        switch(number){
            case 1:
                Console.WriteLine("Find the sword");
                break;
            case 2:
                Console.WriteLine("Rescue a villager");
                break;
            case 3:
                Console.WriteLine("Inspect the dungeon");
                break;
            default:
                Console.WriteLine("Select to choose the quest");
                number = Convert.ToInt32(Console.ReadLine());
                break;
        }
        //Question 24
        Console.WriteLine("Select the menu option");
        number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.WriteLine("Start");
                break;
            case 2:
                Console.WriteLine("Option");
                break;
            case 3:
                Console.WriteLine("Load game");
                break;
            case 4:
                Console.WriteLine("Exit");
                break;
            default:
                Console.WriteLine("Select the menu option");
                number = Convert.ToInt32(Console.ReadLine());
                break;
        }
    }
}