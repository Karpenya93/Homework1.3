using System.Linq;

Console.Write("Введите число ");
string number = Console.ReadLine();
char[] c = number.ToCharArray();
Array.Reverse(c);
int truenumber = Convert.ToInt32(number);
string newc = String.Concat<char>(c);
int truenumber2 = Convert.ToInt32(newc);
if (truenumber == truenumber2)
    Console.WriteLine("Это возмутимо но это полиндром");
else
    Console.WriteLine("Это возмутимо но это не полидром");





