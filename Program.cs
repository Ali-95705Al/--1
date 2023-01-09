Console.WriteLine("Введите число 1: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2: ");
int b = Convert.ToInt32(Console.ReadLine());

int result;
result = a - b;

//Если result < 0 => a меньше b
//Если result > 0 => a больше b

if (result < 0)
{      //Если result< 0 =>
   Console.WriteLine ("a меньше b");
}
else
{    // Если result > 0 =>
   Console.WriteLine ("a больше b"); 
}