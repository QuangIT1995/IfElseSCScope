internal class Program
{
    private static void Main(string[] args)
    {
        //part 1
        int inputNumber1 = int.Parse(Console.ReadLine());
        int inputNumber2 = int.Parse(Console.ReadLine());
        if(inputNumber1 == inputNumber2){
            Console.WriteLine("Two number are equal");
        }
        //part 2
        inputNumber1 = int.Parse(Console.ReadLine());
        inputNumber2 = int.Parse(Console.ReadLine());
        if(inputNumber1 > inputNumber2){
            Console.WriteLine($"{inputNumber1} is greater than {inputNumber2}");
        }
        //part 3
        inputNumber1 = int.Parse(Console.ReadLine());
        inputNumber2 = int.Parse(Console.ReadLine());
        if(inputNumber1 < inputNumber2){
            Console.WriteLine($"{inputNumber1} is less than {inputNumber2}");
        }
        //part 4
        inputNumber1 = int.Parse(Console.ReadLine());
        inputNumber2 = int.Parse(Console.ReadLine());
        if(inputNumber1 != inputNumber2){
            Console.WriteLine("Two number are not equal");
        }
        //part 5
        inputNumber1 = int.Parse(Console.ReadLine());
        inputNumber2 = int.Parse(Console.ReadLine());
        if(inputNumber1 >= inputNumber2){
            Console.WriteLine($"{inputNumber1} is equal or greater than {inputNumber2}");
        }
        //part 6
        inputNumber1 = int.Parse(Console.ReadLine());
        inputNumber2 = int.Parse(Console.ReadLine());
        if(inputNumber1 <= inputNumber2){
            Console.WriteLine($"{inputNumber1} is equal or less than {inputNumber2}");
        }
        //part 7
        int number1 = 4;
        int number2 = 6;
        int requestAnswer = number1 + number2;
        int inputResult = int.Parse(Console.ReadLine());
        if(inputResult == requestAnswer){
            Console.WriteLine("Correct!");
        }
        else{
            Console.WriteLine("Wrong!");
        }
        //part 8
        int boundedAge = 18;
        int inputAge = int.Parse(Console.ReadLine());
        if(inputAge > boundedAge){
            Console.WriteLine("You are old enough to vote");
        }
        else{
            Console.WriteLine("You are not old enough to vote");
        }
        //part 9
        int enemyHealth = 75;
        if(enemyHealth == 100){
            Console.WriteLine($"Enemy HP: {enemyHealth}");
        }
        else if(enemyHealth == 75){
            Console.WriteLine($"Enemy HP: {enemyHealth}");
        }
        else if(enemyHealth == 50){
            Console.WriteLine($"Enemy HP: {enemyHealth}");
        }
        else if(enemyHealth == 25){
            Console.WriteLine($"Enemy HP: {enemyHealth}");
        }
        else if(enemyHealth == 0){
            Console.WriteLine($"Enemy HP: {enemyHealth}");
        }
        //part 10
        int userAge = int.Parse(Console.ReadLine());
        if(userAge >= 18) Console.WriteLine("You got a discount");
        else if(userAge < 18) Console.WriteLine("You haven't get a discount");
    }
}