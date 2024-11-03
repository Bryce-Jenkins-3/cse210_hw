using System;
using System.ComponentModel;

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
        
        Resume resume1 = new Resume();
        resume1._name = "Billy Bob";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        Console.Write(resume1._jobs[0]._jobTitle);
    }
}