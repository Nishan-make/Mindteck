public class Student
{
    public int roll = 1;
    public string name =" ";
    public int marks = 0;
    private string state = " ";
    protected string schoolname = " ";

    public Student()
    { }
    public Student(int r, string n, int m)
    {
        roll = r;
        name = n;
        marks = m;
    }

    public void print_details()
    {
        Console.WriteLine(name + "(rollno " + roll + ")" + " has scored " + marks + " marks.");
    }

    public void statement_grade()
    {
        Console.WriteLine(".................Result Status...................................");
        if (marks > 40)
        {
            if (marks <= 100)
                Console.WriteLine("Result :Pass");
            int n = marks / 10;
            switch (n)
            {
                case 4:
                    Console.WriteLine("Remarks: Study ! Study ! Study....otherwise next year you will be failed");
                    break;
                case 5:
                    Console.WriteLine("Remarks: be focused,Not safe");
                    break;
                case 10:
                    Console.WriteLine("Remarks :Outstanding,you are the future.");
                    break;
                case 9:
                    Console.WriteLine("Remarks: Excellent Performance");
                    break;
                case 8:
                    Console.WriteLine("Remarks: Very Good");
                    break;
                case 7:
                    Console.WriteLine("Remarks: Good");
                    break;
                case 6:
                    Console.WriteLine("Remarks: Not Bad");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }
        }
        else
        {

            Console.WriteLine("Result :Fail");
            Console.WriteLine("Remarks :Congratulation! Inform your guardian and tell them to come.");

        }
        Console.WriteLine("....................................................");

    }
    public void comparison(Student s)
    {
        if (s.marks > marks)
            Console.WriteLine(s.name + " has scored better than " + name);
        else if (s.marks == marks)
            Console.WriteLine("Tuklibaz! Both have scored same..");
        else
            Console.WriteLine(name + " has scored better than " + s.name);
    }

}