using System;
using System.Collections;

public class Class1
{
    public Class1()
    {
        var al = new ArrayList();
        al.Add(1);
        al.Add("Nishan");
        al.Add(null);
        al.Add(" ");
        al.Add(2.4f);
        foreach (var ar2 in al)
            Console.WriteLine(ar2);
    }
}