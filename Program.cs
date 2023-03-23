using Assignemnt1;
using Assignment1;

var course = new Course
{
    Title = "C# Fundamentals",
    Teacher = new Instructor
    {
        Name = "Jalal Uddin",
        Email = "jalal.exe@gmail.com",
        PresentAddress = new Address
        {
            Street = "Mirpur 10",
            City = "Dhaka",
            Country = "Bangladesh"
        },
        PermanentAddress = new Address
        {
            Street = "Mirpur 10",
            City = "Dhaka",
            Country = "Bangladesh"
        },
        PhoneNumbers = new List<Phone>
        {
            new Phone
            {
                Number = "180XXXXXXX",
                Extension = "",
                CountryCode = "+880"
            }
        }
    },
    Topics = new List<Topic>
    {
        new Topic
        {
            Title = "Intro to C#",
            Description = "Learn the basics of C# language",
            Sessions = new List<Session>
            {
                new Session
                {
                    DurationInHour = 2,
                    LearningObjective = "Understand the syntax and new features of C# language"
                }
            }
        }
    },
    Fees = 8000,
    Tests = new List<AdmissionTest>
    {
        new AdmissionTest
        {
            StartDateTime = new DateTime(2022, 01, 01, 10, 0, 0),
            EndDateTime = new DateTime(2022, 01, 01, 12, 0, 0),
            TestFees = 100
        }
    }
};



//var test = course.GetType().GetProperties();


//Console.WriteLine(test[4]);

string json = JsonFormatter.Convert(course);
Console.WriteLine(json);
