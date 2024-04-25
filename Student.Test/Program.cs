using Jewlery.Test.Shembull;

string Type = "Ring";
char Material = 'G';
int Collection = 2024;
string StoneName ="Diamond";

// asd
//Student.Test.Student student = new Student.Test.Student();
//student.FirstName = "Emri";

//Console.WriteLine(student.FirstName);

//Student.Test.Student student2 = new Student.Test.Student("Emri 2", "Mbiemri 2");

//Console.WriteLine(student2.FirstName);
var allJewlery = new List<Jewlery.Test.Jewlery>()
{
    new Jewlery.Test.Jewlery()
    {
        Type = "Ring"
    },
    new Jewlery.Test.Jewlery()
    {
        Type = "Bracelet"
    }
};


foreach (var jewlery in allJewlery)
{
    Console.WriteLine(jewlery.Type);
}

Console.ReadLine();
