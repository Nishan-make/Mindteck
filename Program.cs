using System;

    class MyCode
    {
        static void Main(string[] arg)
        {
        /*string firstname = "Nishan";
        string lastname = "Mal";
        Console.WriteLine(firstname + lastname);
        string name = "Mindteck";
        string rname="";
        for (int i=name.Length-1; i>=0; i--)
        {
            rname+=(name[i]);
            Console.WriteLine(name[i]);
        }
        Console.WriteLine(rname);

        int[] roll = { 2, 12, 5, 67, 3 };
        Console.WriteLine("...............unsorted...................");
        foreach (var n in roll)
            Console.WriteLine(n);
        Array.Sort(roll);
        Console.WriteLine(".................after sorting.............");
        foreach (var n in roll)
            Console.WriteLine(n);*/
        Class1 class1 = new Class1();
        var d1=new List<Student>()
        {
            new Student(){roll=12,name="Subhadeep",marks=99},
            new Student(){roll=2,name="Somobrita",marks=25},
            new Student(){roll=1,name="Debjit",marks=87},
            new Student(){roll=10,name="Tania",marks=69},
            new Student(){roll=22,name="Shyansundar",marks=90}
        };
        var elst = from lst in d1
                   where lst.marks >= 80
                   select lst;
        
        Console.WriteLine("-------------Good Students are -------------------");
        Console.WriteLine("marks\tName");
        Console.WriteLine("-----\t----");
        foreach (var item in elst)
            Console.WriteLine(item.marks+"\t"+item.name);
        
        d1.Add(new Student() { roll = 11, name = "Poulami", marks = 70 });//adding an element.

        Console.WriteLine("---------------------After adding one element all student details------------");
        var olist = from lst in d1
                    orderby lst.roll
                    select lst;//sorting elements by rollno.
        Console.WriteLine("-Student details are sorted by roll number-");
        Console.WriteLine("Roll\tName");
        Console.WriteLine("----\t----");
        foreach (var item in olist)
            Console.WriteLine(item.roll+"\t"+item.name);
        Console.WriteLine("Now there are " + d1.Count + " student's details inserted");//using count.

        

    }
    public class Student
    {
        public int roll { get; set; }
        public string name { get; set; }    
        public int marks { get; set; }

    }

}
