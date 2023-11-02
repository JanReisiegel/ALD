using _04_cv.Models;
/*
List<int> list = new List<int> { 5, 1, 3, 8, 9, 10, 81, 90, 67, 8, 5, 4 };
Bogosort<int> bs = new Bogosort<int>();
list=bs.BogoSort(list);
string sList = "";
foreach (int i in list)
{
    sList += $"{i} ";
}
Console.WriteLine($"Počet prvků v poli: {list.Count}");
Console.WriteLine(sList);
Console.WriteLine(bs.Counter);*/

/*List<Student> students = new List<Student>();
SortStudent sort = new SortStudent();
students.Add(new Student("M22000180", "Michal", "Pokorný", DateTime.Parse("2002/11/7")));
students.Add(new Student("M22000101", "Petr", "Konopný", DateTime.Parse("2002/02/6")));
students.Add(new Student("M22000132", "Honza", "Jablečný", DateTime.Parse("2002/12/5")));
students.Add(new Student("M22000103", "Michal", "Vlasák", DateTime.Parse("2002/04/4")));
students.Add(new Student("M22000124", "Gustav", "Masák", DateTime.Parse("2002/03/3")));
students.Add(new Student("M22000115", "Xénie", "Podhorná", DateTime.Parse("2002/12/2")));
students.Sort((Student s1, Student s2) =>
{
    if(s1.StudentNumber.CompareTo(s2.StudentNumber) <= 0)
    {
        return -1;
    }
    return 1;
});
foreach (Student student in students)
{
    Console.WriteLine(student.ToString());
}*/

GPS gps = new GPS();
while (true)
{
    string[] input = Console.ReadLine().Split(" ");
    switch (input[2])
    {
        case "nejkratsi":
            Console.WriteLine(gps.GetNejkratsi(input[0], input[1]));
            break;
        default:
            return;
    }
}