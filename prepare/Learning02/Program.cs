using System;

public class Job
{
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "DELL";
        job1._startYear = 2002;
        job1._endYear = 2012;

        Job job2 = new Job();
        job2._jobTitle = "Electrical Engineer";
        job2._company = "Intel";
        job2._startYear = 2012;
        job2._endYear = 2020;

        job1.Display();
        job2.Display();
        
    }
}