// See https://aka.ms/new-console-template for more information
using BureTools;

Console.Write("Here is the test! :D\n");
Debug.Info(DateTime.Now);

int[] array = null;
foreach (int num in array.AsNullable())
{
    num.Log();
}
Debug.Info("End!","Test");

Console.Read();