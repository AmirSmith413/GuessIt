//Review: Michelle 
//Working, but hard to know what to type for difficulty level and no replay option




//Mini Challenge # 8
//Finished on 8/18/22
//Peer Reviewed by:Angelica Ayala

//program asks difficulty
//user enters difficulty
//depending on difficulty program chooses a number
//user enters a number
//if answer is wrong user must pick again until they guess it right
Random random = new Random();
string userDifficulty;

int randomNumE = random.Next(1,10);
int randomNumM = random.Next(1,50);
int randomNumH = random.Next(1,100);
int guessNum = 0;




Console.WriteLine("Please select a difficulty.");
userDifficulty = Console.ReadLine();

    
if(userDifficulty == "Easy")
{
   Console.WriteLine("I'm thinking of a number between 1 and 10.What is the number?");
   
   

while(guessNum != randomNumE)
{
    guessNum = Convert.ToInt32(Console.ReadLine());
    if(guessNum < randomNumE)
    {
        Console.WriteLine("No, I'm thinking higher than " + guessNum + ".");
    }
    else if(guessNum > randomNumE)
    {
        Console.WriteLine("No, I'm thinking lower than " + guessNum + ".");
    }
    if(guessNum == randomNumE)
    {
        Console.WriteLine("Yes i was thinking of " + guessNum + ".");
    }
}
}
if(userDifficulty == "Medium")
{
   Console.WriteLine("I'm thinking of a number between 1 and 50.What is the number?");
   
   

while(guessNum != randomNumM)
{
    guessNum = Convert.ToInt32(Console.ReadLine());
    if(guessNum < randomNumM)
    {
        Console.WriteLine("No, I'm thinking higher than " + guessNum + ".");
    }
    else if(guessNum > randomNumM)
    {
        Console.WriteLine("No, I'm thinking lower than " + guessNum + ".");
    }
    if(guessNum == randomNumM)
    {
        Console.WriteLine("Yes i was thinking of " + guessNum + ".");
    }
}
}
if(userDifficulty == "Hard")
{
   Console.WriteLine("I'm thinking of a number between 1 and 100.What is the number?");
   
   

while(guessNum != randomNumH)
{
    guessNum = Convert.ToInt32(Console.ReadLine());
    if(guessNum < randomNumH)
    {
        Console.WriteLine("No, I'm thinking higher than " + guessNum + ".");
    }
    else if(guessNum > randomNumH)
    {
        Console.WriteLine("No, I'm thinking lower than " + guessNum + ".");
    }
    if(guessNum == randomNumH)
    {
        Console.WriteLine("Yes i was thinking of " + guessNum + ".");
    }
}
}

