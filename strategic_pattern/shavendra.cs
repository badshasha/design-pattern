namespace shavendra{

    public interface IFlyBehaviour
    {
        void fly();   
    }

    public class FlyHigh: IFlyBehaviour{
        public void fly(){
            Console.WriteLine("fly high");
        }
    }

    public class CantFly:IFlyBehaviour{
        public void fly(){
            Console.WriteLine("cant fly");
        }
    }

    public interface IQuackBEhavour{
        void quack();    
    }

    public class NoSound : IQuackBEhavour{
        public void quack(){
            Console.WriteLine("bid sound mute");
        }
    }


    public class Duck{
        public IFlyBehaviour? flyBehavior{get; set;}
        public IQuackBEhavour? queckBehavior{get; set;}

    

        public void perforQueck(){    
            if (this.queckBehavior != null){
                this.queckBehavior.quack();
            }    
            
        }

        public void performFly(){
            if ( this.flyBehavior != null){
                this.flyBehavior.fly();
            }else{
                Console.WriteLine("error");
            }
            
        }

    }


    class liveDuck:Duck
    {
        public liveDuck(IFlyBehaviour flyBehaviour,IQuackBEhavour queckBehavior)
        {
           base.flyBehavior = flyBehaviour;
           base.queckBehavior = queckBehavior;
        }
    }



}