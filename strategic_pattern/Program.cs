// See https://aka.ms/new-console-template for more information
using shavendra;



class Program{

    

    public static void Main(string[] args){

        Console.WriteLine("working");

        Duck d = new liveDuck(new FlyHigh() , new NoSound());
        d.performFly();
    }

}

