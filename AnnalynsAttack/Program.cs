using AnnalynsAttack;
using Batch;
using Microsoft.VisualBasic;
using static AnnalynsAttack.LogLine;

public class Program
{
    static void Main() 
    {
        //var knightIsAwake = true;
        //Console.WriteLine(QuestLogic.CanFastAttack(knightIsAwake));

        //knightIsAwake = false;
        //var archerIsAwake = true;
        //var prisonerIsAwake = false;
        //Console.WriteLine(QuestLogic.CanSpy(knightIsAwake, archerIsAwake, prisonerIsAwake));

        //archerIsAwake = false;
        //prisonerIsAwake = true;
        //Console.WriteLine(QuestLogic.CanSignalPrisoner(archerIsAwake, prisonerIsAwake));

        //knightIsAwake = false;
        //archerIsAwake = true;
        //prisonerIsAwake = false;
        //var petDogIsPresent = false;
        //Console.WriteLine(QuestLogic.CanFreePrisoner(knightIsAwake, archerIsAwake, prisonerIsAwake, petDogIsPresent));

        //Console.WriteLine(AssemblyLine.SuccessRate(10));
        //Console.WriteLine(AssemblyLine.ProductionRatePerHour(6));
        //Console.WriteLine(AssemblyLine.WorkingItemsPerMinute(6));

        //int[] birdsPerDay = { 2, 5, 0, 7, 4, 1 };
        //BirdCount birdCount = new(birdsPerDay);
        //birdCount.IncrementTodaysCount();
        //Console.WriteLine(birdCount.HasDayWithoutBirds());
        //Console.WriteLine(birdCount.CountForFirstDays(4));
        //Console.WriteLine(birdCount.BusyDays());
        //Console.WriteLine(birdCount.Today());

        //Console.WriteLine(Appointment.Schedule("7/25/2019 13:45:00"));
        //Console.WriteLine(Appointment.HasPassed(new DateTime(1999, 12, 31, 9, 0, 0)));
        //Console.WriteLine(Appointment.IsAfternoonAppointment(new DateTime(2019, 03, 29, 15, 0, 0)));
        //Console.WriteLine(Appointment.Description(new DateTime(2019, 03, 29, 15, 0, 0)));
        //Console.WriteLine(Appointment.AnniversaryDate());

        //Console.WriteLine(SavingsAccount.InterestRate(200.75m));
        //Console.WriteLine(SavingsAccount.Interest(200.75m));
        //Console.WriteLine(SavingsAccount.AnnualBalanceUpdate(200.75m));
        //Console.WriteLine(SavingsAccount.YearsBeforeDesiredBalance(200.75m, 214.88m));

        //Console.WriteLine(DialingCodes.GetCountryNameFromDictionary(DialingCodes.GetExistingDictionary(), 55));
        //Console.WriteLine(DialingCodes.FindLongestCountryName(DialingCodes.GetExistingDictionary()));

        //Console.WriteLine(Badge.Print(734, "Ernest Johnny Payne", "Strategic Communication"));
        //Console.WriteLine(Badge.Print(id: null, "Jane Johnson", "Procurement"));
        //Console.WriteLine(Badge.Print(254, "Charlotte Hale", department: null));
        //Console.WriteLine(Badge.Print(id: null, "Charlotte Hale", department: null));

        //var log = "[INFO]: File Deleted.";
        //Console.WriteLine(log.SubstringAfter(": "));
        //Console.WriteLine(log.SubstringBetween("[", "]"));
        //Console.WriteLine(log.Message());
        //Console.WriteLine(log.LogLevel());

        //Console.WriteLine(LogLine.ParseLogLevel("[INF]: File deleted"));
        //Console.WriteLine(LogLine.ParseLogLevel("[XYZ]: Overly specific, out of context message"));
        //Console.WriteLine(LogLine.OutputForShortLog(LogLevel.Error, "Stack overflow"));

        var wm = new WeighingMachine(precision: 3);
        wm.Weight = 60.567;
        wm.TareAdjustment = 10;
        Console.WriteLine($"{ wm.Precision} {wm.Weight}");
        Console.WriteLine(wm.DisplayWeight);
    }
}

