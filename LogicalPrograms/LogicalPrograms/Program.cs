Console.WriteLine("1.Fabonacci Series\n2.Perfect Number\n3.Prime Number\n4.Reverse Number\n5.Stop Watch\n6.Coupon Number\n7.Day of Week\n8.Temperatue Conversion\n9.Monthly Payment\n10.Binary Conversion");
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
    case 5:
        LogicalPrograms.StopWatch watch = new LogicalPrograms.StopWatch();
        watch.watch();
        break;
    case 6:
        LogicalPrograms.Coupon coupon = new LogicalPrograms.Coupon();
        coupon.getCoupon();
        break;
    case 7:
        LogicalPrograms.dayOfWeek day = new LogicalPrograms.dayOfWeek();
        day.getDay();
        break;
    case 8:
        LogicalPrograms.Temperature.celToFah();
        LogicalPrograms.Temperature.FahToCel();
        break;
    case 9:
        LogicalPrograms.monthlyPayment.calculateEMI();
        break;
    case 10:
        LogicalPrograms.Binary.getBinary();
        break;
    default:
        Console.WriteLine("Enter valid option.");
        break;
}