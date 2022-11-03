// int sum = 0;
// int startNumber = 1;

// while (startNumber <= 10)
// {
//    if ( startNumber % 2 == 0 )
//    {
//        sum = sum + startNumber;
//    }
//    startNumber = startNumber + 1;
//}
// Console.WriteLine(sum);


// Version 2
int sum = 0;
int startNumber = 2;

while (startNumber <= 10)
{
  sum = sum + startNumber;
  startNumber = startNumber + 2;
}
Console.WriteLine(sum);