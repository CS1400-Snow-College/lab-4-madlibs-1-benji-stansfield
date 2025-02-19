//Benji Stansfield, 02-16-25, Lab 4 "Madlibs 1"

Console.Clear();

//Greeting
Console.WriteLine(@"This is Mad Libs. When you are done providing the requested words I will build them into a funny story for you.
Press any key to continue.");
Console.ReadKey(true);

Console.WriteLine(@"
Please enter the requested word types:");

//Taking apart the original story
string originalStory = "A vacation is when you take a trip to some (adjective) place with your (adjective) family. Usually, you go to some place that is near a/an (noun) or up on a/an (noun). A good vacation place is one where you can ride (plural_noun) or play (game) or go hunting for (plural_noun). I like to spend my time (verb_ending_in_“ing”) or (verb_ending_in_“ing”). When parents go on a vacation, they spend their time eating three (plural_noun) a day, and fathers play golf, and mothers sit around (verb_ending_in_“ing”). Last summer, my little brother fell in a/an (noun) and got poison (plant) all over his (part_of_the_body). My family is going to go to (place) and I will practice (verb_ending_in_“ing”). Parents need vacations more than kids because parents are always very (adjective) and because they have to work (number) hours every day all year making enough (plural_noun) to pay for the vacation.";
string[] storyWords = originalStory.Split(' ');

//Creating a new story
string[] newStoryWords = new string[storyWords.Length];

//Analyzing the words
for (int i = 0; i < storyWords.Length; i++)
{
    if (storyWords[i].Contains("("))
    {
        string wordType = storyWords[i].Replace("(", "").Replace(")", "").Replace(".", "");

        Console.Write($"Please give me an example of a/an {wordType}: ");
        string userWord = Console.ReadLine(); /*this asks the user for the type of word it needs*/
        if(storyWords[i].Contains("."))
        {
            userWord = userWord + ".";
        }
        newStoryWords[i] = userWord;
    }
    else
    {
        newStoryWords[i] = storyWords[i];
    }
}

//Writing the new story
string newStory = string.Join(" ", newStoryWords);
Console.WriteLine(newStory);
