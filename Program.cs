// Console.Write("Imput number: ");
// int i = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(i*i);



Console.Write("Imput number_1: ");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput number_2: ");
int number_2 = Convert.ToInt32(Console.ReadLine());

if (number_1 == number_2*number_2)
    Console.WriteLine("a = "+ number_1 +", b = "+ number_2 +" -> yes");
else
    Console.WriteLine("a = "+ number_1 +", b = "+ number_2 +", -> no");