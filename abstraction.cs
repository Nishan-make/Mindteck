using System;

public abstract class Parent
{
    public abstract int maths_done();
    public void suggestion()
    {
        Console.WriteLine("Afetr completing min. 5 maths you can go to play");
    }
    public virtual void play()
    {
        Console.WriteLine("mention your favourite game.");
    }
}

public class child1: Parent
{
    public override int maths_done()
    {
        Console.WriteLine("Child1 has completed 5 problems");
        return 5;

    }
    public override void play()
    {
        Console.WriteLine("Child1 likes to play cricket\n");
    }
}

public class child2 : Parent
{
    public override int maths_done()
    {
        Console.WriteLine("Child2 has completed 3 problems");
        return 3;

    }
    public override void play()
    {
        Console.WriteLine("Child2 likes to play football\n");
    }
}

public class child3 : Parent
{
    public override int maths_done()
    {
        Console.WriteLine("Child3 has completed 10 problems");
        return 10;

    }
    public override void play()
    {
        Console.WriteLine("Child3 likes to play Golf\n");
    }
}

;public class Abs
{
    public static void Main(string[] args)
    {
        child1 ch1 = new child1();
        child2 ch2 = new child2();
        child3 ch3 = new child3();
        
        ch1.suggestion();
  
        ch1.play();
        ch2.play();
        ch3.play();

        int[] md={ ch1.maths_done(), ch2.maths_done(), ch3.maths_done() };
        Console.WriteLine(".................permission to play......................");
     
        for (int i=0;i<3;i++)
        {
            if (md[i]>=5)
                Console.WriteLine("Child"+(i+1)+" got the permission.");
            else
                Console.WriteLine("Child" +(i+1)+" will not go.");
        }

    }
}