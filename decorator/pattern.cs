namespace shavendra{

        public abstract class Character{

            public string Desctiption { get;  protected set; }

            
            public string GetDesctioption(){
                return this.Desctiption;
            }

            public abstract string power();

        }


        public class Hero : Character{

            public Hero(string description){
                base.Desctiption = description;
            }

            public override string power()
            {
                return   "Hero :";
            }
        }




        // create decorators 

        public abstract class Power : Character{
            protected Character game_character;
            public  abstract string GetDesctioption();
        }


        public class SuperStrengthPower : Power
        {
            public SuperStrengthPower(Character gamecharacter){
                game_character = gamecharacter;
            }

            public override string GetDesctioption()
            {
                Console.WriteLine(base.game_character.GetDesctioption());
                return base.game_character.GetDesctioption() + " i have strength";
            }

            public override string power()
            {
                return base.game_character.power() + " : strong";
            }
        }



}
