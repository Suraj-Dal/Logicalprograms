﻿Console.WriteLine("1.Fabonacci Series\n2.Perfect Number\n3.Prime Number\n4.Reverse Number\n");
Console.WriteLine("Enter your choice:");
int choice = Convert.ToInt32(Console.ReadLine());
switch (choice)
{
    case 1:
        LogicalPrograms.Fabonacci fab = new LogicalPrograms.Fabonacci();
        fab.series();
        break;
    case 2:
        LogicalPrograms.PerfectNumber per = new LogicalPrograms.PerfectNumber();
        per.perfect();
        break;
    case 3:
        LogicalPrograms.Prime prime = new LogicalPrograms.Prime();
        prime.check();
        break;
    case 4:
        LogicalPrograms.Reverse rev = new LogicalPrograms.Reverse();
        rev.perform();
        break;
}