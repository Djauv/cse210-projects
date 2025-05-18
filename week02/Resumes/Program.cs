using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Linux";
        job1._startYear = 2022;
        job1._endYear = 2024;

        Job job2 = new Job();
        job2._company = "Relogic";
        job2._jobTitle = "Artist";
        job2._startYear = 2014;
        job2._endYear = 2016;

        Resume resume1 = new Resume();
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1._name = "Gabe Auvinen";
        resume1.ResumeDetails();
    }
}