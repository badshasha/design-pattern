// code by shavendra
// source : learn decorator pattern 

// lead classes 

using shavendra;


class Program{

    public static void Main(string[] args){
        

        Character gamePlayer1 = new Hero("i am a hero");
        gamePlayer1 = new SuperStrengthPower(gamePlayer1);

        Console.WriteLine(gamePlayer1.power());
       

    }

}
