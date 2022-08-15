//Write a method that will print to the console all numbers 1000 through -1000.
for (int i = 1000; i >= -1000; i--)
{
    Console.WriteLine(i);
}
//Write a method that will print to the console numbers 3 through 999 by 3 each time.



for (int k = 3; k <= 999; k += 3)
{
    Console.WriteLine(k);
}


//Write a method to accept two integers as parameterss and check whether they are equal or not

    static bool IsEqual(int a, int b)
  { 
    if (a == b)
    {
        return true;
    }

    return false;



  }