using System.Security.Cryptography;

internal class Program
{
    private static void Main(string[] args)
    {
        //Question 1
        int number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.WriteLine($"This is number {number}");
                break;
            case 2:
                Console.WriteLine($"This is number {number}");
                break;
            case 3:
                Console.WriteLine($"This is number {number}");
                break;
            default:
                Console.WriteLine("Choose again!");
                break;
        }
        //Question 2
        number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.WriteLine("You choose Warrior class");
                break;
            case 2:
                Console.WriteLine("You chooese Mage class");
                break;
            case 3:
                Console.WriteLine("You choose Archer class");
                break;
            default:
                Console.WriteLine("Choose your class");
                break;
        }
        //Question 3
        number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.WriteLine("You go to the North");
                break;
            case 2:
                Console.WriteLine("You go to the South");
                break;
            case 3:
                Console.WriteLine("You go to the West");
                break;
            case 4:
                Console.WriteLine("You go to the East");
                break;
            default:
                Console.WriteLine("Please choose the direction");
                break;
        }
        //Question 4
        number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Please choose the day of the week");
                break;
        }
        //Question 5
        number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.WriteLine("You choose Sword");
                break;
            case 2:
                Console.WriteLine("You choose Bow");
                break;
            case 3:
                Console.WriteLine("You choose Staff");
                break;
            case 4:
                Console.WriteLine("You choose Axe");
                break;
            default:
                Console.WriteLine("Please choose the weapon");
                break;
        }
        //Question 6
        number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.WriteLine("You choose Fire");
                break;
            case 2:
                Console.WriteLine("You choose Water");
                break;
            case 3:
                Console.WriteLine("You choose Earth");
                break;
            case 4:
                Console.WriteLine("You choose Air");
                break;
            case 5:
                Console.WriteLine("You choose Lighting");
                break;
            default:
                Console.WriteLine("Please choose the element");
                break;
        }
        //Question 7
        number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.WriteLine("Start game");
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
                Console.WriteLine("Menu choose");
                break;
        }
        //Question 8
        number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.WriteLine("Talk");
                break;
            case 2:
                Console.WriteLine("Trade");
                break;
            case 3:
                Console.WriteLine("Quest");
                break;
            default:
                Console.WriteLine("Interact with NPC");
                break;
        }
        //Question 9
        number = Convert.ToInt32(Console.ReadLine());
        switch (number)
        {
            case 1:
                Console.WriteLine("You choose Multiple Choice");
                break;
            case 2:
                Console.WriteLine("You choose Inventory Puzzle");
                break;
            case 3:
                Console.WriteLine("You choose Logic Puzzle");
                break;
            case 4:
                Console.WriteLine("You choose Environmental Puzzle");
                break;
            case 5:
                Console.WriteLine("You choose Pattern Puzzle");
                break;
            default:
                Console.WriteLine("Choose any puzzle you want");
                break;
        }
        //Question 10
        number = Convert.ToInt32(Console.ReadLine());
        switch (number){
            case 1:
                Console.WriteLine("I'm so good.");
                break;
            case 2:
                Console.WriteLine("How are you today, buddy?");
                break;
            case 3:
                Console.WriteLine("Booya! We did it buddy!");
                break;
            case 4:
                Console.WriteLine("Come with me boy!");
                break;
            default:
                Console.WriteLine("Choose your dialogue");
                break;
        }
        //Question 11
        number = Convert.ToInt32(Console.ReadLine());
        switch (number){
            case 1:
                Console.WriteLine("Potion");
                break;
            case 2:
                Console.WriteLine("Weapon");
                break;
            case 3:
                Console.WriteLine("Armor");
                break;
            default:
                Console.WriteLine("Choose an item to craft");
                break;
        }
        //Question 12
        number = Convert.ToInt32(Console.ReadLine());
        switch (number){
            case 1:
                Console.WriteLine("Forest");
                break;
            case 2:
                Console.WriteLine("Swarp");
                break;
            case 3:
                Console.WriteLine("Riverbank");
                break;
            case 4:
                Console.WriteLine("Town");
                break;
            case 5:
                Console.WriteLine("Dessert");
                break;
            default:
                Console.WriteLine("Choose the scene");
                break;
        }
        //Question 13
        number = Convert.ToInt32(Console.ReadLine());
        switch (number){
            case 1:
                Console.WriteLine("Find the cargo");
                break;
            case 2:
                Console.WriteLine("Go to the next town");
                break;
            case 3:
                Console.WriteLine("Defeat the goblin");
                break;
            case 4:
                Console.WriteLine("Defeat the gang leader");
                break;
            default:
                Console.WriteLine("Choose the quest");
                break;
        }
        //Question 14
        number = Convert.ToInt32(Console.ReadLine());
        switch (number){
            case 1:
                Console.WriteLine("Health Potion");
                break;
            case 2:
                Console.WriteLine("Mana Potion");
                break;
            case 3:
                Console.WriteLine("Stamina Potion");
                break;
            default:
                Console.WriteLine("Choose a potion to brew");
                break;
        }
        //Question 15
        number = Convert.ToInt32(Console.ReadLine());
        switch (number){
            case 1:
                Console.WriteLine("Left");
                break;
            case 2:
                Console.WriteLine("Right");
                break;
            case 3:
                Console.WriteLine("Jump");
                break;
            case 4:
                Console.WriteLine("Crouch");
                break;
            default:
                Console.WriteLine("Choose to handle movement");
                break;
        }
    }
}