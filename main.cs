using System;
using System.Linq;
class Program {
  public static void Main (string[] args) {

int sumodd=0;
int sumeven=0;
int[] input = new int[10];
int[] OddNum = new int[10];
int[] EvenNum = new int[10];

for(int pos=0; pos<10; pos++)
{
  Console.WriteLine("Enter a whole number:");
  input[pos] = Convert.ToInt32(Console.ReadLine());
  
    if (input[pos] % 2==0)
    {
      EvenNum[pos]=input[pos];
    }

    else
    {
      OddNum[pos]=input[pos];
    }
  }

Array.Reverse(EvenNum);
Console.WriteLine("Even numbers: ");
foreach(int item in EvenNum)
{
  Console.WriteLine(item);
  sumeven+=item;
}
Console.WriteLine("Sum of even numbers= "+sumeven);


 Console.WriteLine("Odd numbers: ");
Array.Reverse(OddNum);
foreach(int item in OddNum)
{
  Console.WriteLine(item);
  sumodd+=item;
}
Console.WriteLine("Sum of odd numbers= "+sumodd);




  }
}