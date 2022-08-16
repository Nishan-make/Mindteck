using System;

    class MyCode
    {
        static void Main(string[] arg)
        {
        /*string firstname = "Nishan";
        string lastname = "Mal";
        Console.WriteLine(firstname + lastname);*/
        string name = "Mindteck";
        string rname="";
        for (int i=name.Length-1; i>=0; i--)
        {
            rname+=(name[i]);
            Console.WriteLine(name[i]);
        }
        Console.WriteLine(rname);
        }
    }
