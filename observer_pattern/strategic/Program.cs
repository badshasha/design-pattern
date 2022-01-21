// See https://aka.ms/new-console-template for more information

using shavendra;

class Program{
    
    public static void Main(string[] args){
        

        IChannel channel = new Channel();

        IObserver observer = new SimpleObjserver();
        observer.register(channel);

        
        IObserver observer2 = new SimpleObjserver();
        observer2.register(channel);

        channel.updateValue(1.0f,2.3f);


        observer2.unsubscribe();

        channel.updateValue(1.0f,6);



    }
}
