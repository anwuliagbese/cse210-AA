// Program.cs
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create the first job instance
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2015;
        job1._endYear = 2019;

        // Create the second job instance
        Job job2 = new Job();
        job2._jobTitle = "Product Manager";
        job2._company = "Apple";
        job2._startYear = 2020;
        job2._endYear = 2023;

        // Create a new resume instance and set the name
        Resume myResume = new Resume();
        myResume._personName = "Anwuli Joyce Agbese";

        // Add the jobs to the resume's job list
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display the resume details using the Display method in Resume
        myResume.Display();
    }
}
