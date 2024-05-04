Console.WriteLine("Choices are Yes and No");

string continueProgram = "Yes";

while (continueProgram == "Yes") {

Console.WriteLine("Roll?");

string? shouldRoll = Console.ReadLine();

switch (shouldRoll) {
    case "Yes":
        Random rnd = new Random();
    int rollNum = rnd.Next(100);
    int rollNum2 = rnd.Next(100);
    int rollNum3 = rnd.Next(100);
    
    Console.WriteLine("Your numbers are, "+rollNum+", "+rollNum2+", "+rollNum3);

    if (rollNum == rollNum2 && rollNum2 == rollNum3) {
        Console.WriteLine("Jackpot!");
    }
    else {
        Console.WriteLine("Sad.. try again.");
    }
    break;

    case "No":
        break;

    default:
    Console.WriteLine("Invalid");
    break;
}

Console.WriteLine("Continue?");

string? continueProgram2 = Console.ReadLine();

if (continueProgram2 == "Yes") {
    continueProgram = "Yes";
}
else {
    continueProgram = "No";
}

}