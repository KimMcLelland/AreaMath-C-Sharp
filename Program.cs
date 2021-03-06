// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to Area Math");
Console.WriteLine("To Begin, please enter the three dimensions of your building.");
Console.WriteLine("Please enter the width:");
int width = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the depth:");
int depth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the height:");
int height = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Building Dimensions: " + width + " X " + depth + " X " + height);
int sides = (depth - 1) * 2 * height;
int frontAndBack = (width - 1) * 2 * height;
int walls = sides + frontAndBack;
Console.WriteLine("How many floors are there?");
int floors = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How many external doors?");
int doors = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number of Floors: " + floors);
Console.WriteLine("Number of Doors: " + doors);
Console.WriteLine("How many windows are there?");
int windows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How tall are the windows?");
int windowHeight = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("How wide are the windows?");
int windowWidth = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(windows + " windows: " + windowWidth + " X " + windowHeight);
Console.WriteLine("calculating...");
int windowBlocks = windows * windowWidth * windowHeight;
int wallBlocks = walls - windowBlocks - (doors * 2);
int floorBlocks = ((width - 2) * (depth - 2) * floors) + doors;
int roofBlocks = (width + 2) * (depth + 2);
Console.WriteLine("The amount of blocks you'll need for your walls are: " + wallBlocks);
Console.WriteLine("The amount of blocks you'll need for your floors are: " + floorBlocks);
Console.WriteLine("The amount of blocks (slabs and stairs) you'll likely need for your roof is: " + roofBlocks);
//This is a comment