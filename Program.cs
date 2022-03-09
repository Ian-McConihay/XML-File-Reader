Console.WriteLine("Hello, World!");

Console.WriteLine("Put in a name");
string? input = Console.ReadLine();

Console.WriteLine("How many times do you want to repeat the name");
string? times = Console.ReadLine();

for(int i=0; i< Convert.ToInt32(times); i++){
    Console.WriteLine("Hello "+ input);
}