int likes = 0;
var Names = new List<string>();

while (true)
{
    Console.Write("Enter a name: ");
    string Name = Console.ReadLine();
    if (Name == "")
    {
        Console.WriteLine("No name entered. Exiting program.");
        break;
    }
    Names.Add(Name);
    likes = Names.Count;
    if(likes == 1)
    {
        Console.WriteLine(Names[0] + " likes your post.");
    }

    if (likes == 2)
    {
        Console.WriteLine(Names[0] + " and " + Names[1] + " like your post."); 
    }

    if (likes > 2)
    {
        Console.WriteLine(Names[0] + ", " + Names[1] + " and " + (likes - 2) + " others like your post.");
    } 
}